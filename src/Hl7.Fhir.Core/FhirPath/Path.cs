﻿using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.FhirPath
{
    internal class Path
    {
        // function: ID '(' param_list? ')';
        // param_list: expr(',' expr)*;
        public static readonly Parser<string> Function =
            from id in Lexer.Id
            from lparen in Parse.Char('(')
            from paramlist in Parse.Ref(() => Expression.Expr).DelimitedBy(Parse.Char(','))
            from rparen in Parse.Char(')')
            select id + "(" + String.Join(",", paramlist) + ")";

        // item: element recurse? | function | axis_spec | '(' expr ')';
        public static readonly Parser<string> Item =
            Function
            .Or(from element in Lexer.Element
             from recurse in Lexer.Recurse.Optional()
             select element + recurse.GetOrDefault())
            .XOr(Lexer.AxisSpec)
            .XOr(Parse.Ref(() => Expression.BracketExpr));

        // predicate: (root_spec | item) ('.' item)* ;
        public static readonly Parser<string> Predicate =
            from root in (Lexer.RootSpec.Or(Item))
            from after in (
                from dot in Parse.Char('.')
                from item in Item
                select item).Many()
            select root + "." + String.Join(".",after);                                
    }
}