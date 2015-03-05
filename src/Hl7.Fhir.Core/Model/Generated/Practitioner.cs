﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Thu, Mar 5, 2015 16:19+0100 for FHIR v0.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A person with a  formal responsibility in the provisioning of healthcare or related services
    /// </summary>
    [FhirType("Practitioner", IsResource=true)]
    [DataContract]
    public partial class Practitioner : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Practitioner; } }
        [NotMapped]
        public override string TypeName { get { return "Practitioner"; } }
        
        [FhirType("PractitionerPractitionerRoleComponent")]
        [DataContract]
        public partial class PractitionerPractitionerRoleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PractitionerPractitionerRoleComponent"; } }
            
            /// <summary>
            /// The Organization where the Practitioner performs the roles associated
            /// </summary>
            [FhirElement("managingOrganization", InSummary=true, Order=40)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference ManagingOrganization
            {
                get { return _ManagingOrganization; }
                set { _ManagingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _ManagingOrganization;
            
            /// <summary>
            /// Roles which this practitioner may perform
            /// </summary>
            [FhirElement("role", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Role;
            
            /// <summary>
            /// Specific specialty of the practitioner
            /// </summary>
            [FhirElement("specialty", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Specialty
            {
                get { if(_Specialty==null) _Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Specialty; }
                set { _Specialty = value; OnPropertyChanged("Specialty"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Specialty;
            
            /// <summary>
            /// The period during which the practitioner is authorized to perform in these role(s)
            /// </summary>
            [FhirElement("period", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.Period _Period;
            
            /// <summary>
            /// The location(s) at which this practitioner provides care
            /// </summary>
            [FhirElement("location", InSummary=true, Order=80)]
            [References("Location")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Location
            {
                get { if(_Location==null) _Location = new List<Hl7.Fhir.Model.ResourceReference>(); return _Location; }
                set { _Location = value; OnPropertyChanged("Location"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Location;
            
            /// <summary>
            /// The list of healthcare services that this worker offers at this location of this organization
            /// </summary>
            [FhirElement("healthcareService", InSummary=true, Order=90)]
            [References("HealthcareService")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> HealthcareService
            {
                get { if(_HealthcareService==null) _HealthcareService = new List<Hl7.Fhir.Model.ResourceReference>(); return _HealthcareService; }
                set { _HealthcareService = value; OnPropertyChanged("HealthcareService"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _HealthcareService;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PractitionerPractitionerRoleComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ManagingOrganization != null) dest.ManagingOrganization = (Hl7.Fhir.Model.ResourceReference)ManagingOrganization.DeepCopy();
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
                    if(Specialty != null) dest.Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(Specialty.DeepCopy());
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                    if(Location != null) dest.Location = new List<Hl7.Fhir.Model.ResourceReference>(Location.DeepCopy());
                    if(HealthcareService != null) dest.HealthcareService = new List<Hl7.Fhir.Model.ResourceReference>(HealthcareService.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PractitionerPractitionerRoleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PractitionerPractitionerRoleComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(Location, otherT.Location)) return false;
                if( !DeepComparable.Matches(HealthcareService, otherT.HealthcareService)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PractitionerPractitionerRoleComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if( !DeepComparable.IsExactly(HealthcareService, otherT.HealthcareService)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("PractitionerQualificationComponent")]
        [DataContract]
        public partial class PractitionerQualificationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PractitionerQualificationComponent"; } }
            
            /// <summary>
            /// An identifier for this qualification for the practitioner
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Identifier> Identifier
            {
                get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private List<Hl7.Fhir.Model.Identifier> _Identifier;
            
            /// <summary>
            /// Coded representation of the qualification
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Period during which the qualification is valid
            /// </summary>
            [FhirElement("period", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.Period _Period;
            
            /// <summary>
            /// Organization that regulates and issues the qualification
            /// </summary>
            [FhirElement("issuer", InSummary=true, Order=70)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Issuer
            {
                get { return _Issuer; }
                set { _Issuer = value; OnPropertyChanged("Issuer"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Issuer;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PractitionerQualificationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                    if(Issuer != null) dest.Issuer = (Hl7.Fhir.Model.ResourceReference)Issuer.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PractitionerQualificationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PractitionerQualificationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(Issuer, otherT.Issuer)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PractitionerQualificationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(Issuer, otherT.Issuer)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// A identifier for the person as this agent
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// A name associated with the person
        /// </summary>
        [FhirElement("name", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.HumanName Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }
        
        private Hl7.Fhir.Model.HumanName _Name;
        
        /// <summary>
        /// A contact detail for the practitioner
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ContactPoint> Telecom
        {
            get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.ContactPoint>(); return _Telecom; }
            set { _Telecom = value; OnPropertyChanged("Telecom"); }
        }
        
        private List<Hl7.Fhir.Model.ContactPoint> _Telecom;
        
        /// <summary>
        /// Where practitioner can be found/visited
        /// </summary>
        [FhirElement("address", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Address> Address
        {
            get { if(_Address==null) _Address = new List<Hl7.Fhir.Model.Address>(); return _Address; }
            set { _Address = value; OnPropertyChanged("Address"); }
        }
        
        private List<Hl7.Fhir.Model.Address> _Address;
        
        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        [FhirElement("gender", InSummary=true, Order=130)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AdministrativeGender> GenderElement
        {
            get { return _GenderElement; }
            set { _GenderElement = value; OnPropertyChanged("GenderElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AdministrativeGender> _GenderElement;
        
        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AdministrativeGender? Gender
        {
            get { return GenderElement != null ? GenderElement.Value : null; }
            set
            {
                if(value == null)
                  GenderElement = null; 
                else
                  GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(value);
                OnPropertyChanged("Gender");
            }
        }
        
        /// <summary>
        /// The date  of birth for the practitioner
        /// </summary>
        [FhirElement("birthDate", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.Date BirthDateElement
        {
            get { return _BirthDateElement; }
            set { _BirthDateElement = value; OnPropertyChanged("BirthDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _BirthDateElement;
        
        /// <summary>
        /// The date  of birth for the practitioner
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string BirthDate
        {
            get { return BirthDateElement != null ? BirthDateElement.Value : null; }
            set
            {
                if(value == null)
                  BirthDateElement = null; 
                else
                  BirthDateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("BirthDate");
            }
        }
        
        /// <summary>
        /// Image of the person
        /// </summary>
        [FhirElement("photo", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Attachment> Photo
        {
            get { if(_Photo==null) _Photo = new List<Hl7.Fhir.Model.Attachment>(); return _Photo; }
            set { _Photo = value; OnPropertyChanged("Photo"); }
        }
        
        private List<Hl7.Fhir.Model.Attachment> _Photo;
        
        /// <summary>
        /// The list of Roles/Organizations that the Practitioner is associated with
        /// </summary>
        [FhirElement("practitionerRole", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Practitioner.PractitionerPractitionerRoleComponent> PractitionerRole
        {
            get { if(_PractitionerRole==null) _PractitionerRole = new List<Hl7.Fhir.Model.Practitioner.PractitionerPractitionerRoleComponent>(); return _PractitionerRole; }
            set { _PractitionerRole = value; OnPropertyChanged("PractitionerRole"); }
        }
        
        private List<Hl7.Fhir.Model.Practitioner.PractitionerPractitionerRoleComponent> _PractitionerRole;
        
        /// <summary>
        /// Qualifications obtained by training and certification
        /// </summary>
        [FhirElement("qualification", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Practitioner.PractitionerQualificationComponent> Qualification
        {
            get { if(_Qualification==null) _Qualification = new List<Hl7.Fhir.Model.Practitioner.PractitionerQualificationComponent>(); return _Qualification; }
            set { _Qualification = value; OnPropertyChanged("Qualification"); }
        }
        
        private List<Hl7.Fhir.Model.Practitioner.PractitionerQualificationComponent> _Qualification;
        
        /// <summary>
        /// A language the practitioner is able to use in patient communication
        /// </summary>
        [FhirElement("communication", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Communication
        {
            get { if(_Communication==null) _Communication = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Communication; }
            set { _Communication = value; OnPropertyChanged("Communication"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Communication;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Practitioner;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Name != null) dest.Name = (Hl7.Fhir.Model.HumanName)Name.DeepCopy();
                if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.ContactPoint>(Telecom.DeepCopy());
                if(Address != null) dest.Address = new List<Hl7.Fhir.Model.Address>(Address.DeepCopy());
                if(GenderElement != null) dest.GenderElement = (Code<Hl7.Fhir.Model.AdministrativeGender>)GenderElement.DeepCopy();
                if(BirthDateElement != null) dest.BirthDateElement = (Hl7.Fhir.Model.Date)BirthDateElement.DeepCopy();
                if(Photo != null) dest.Photo = new List<Hl7.Fhir.Model.Attachment>(Photo.DeepCopy());
                if(PractitionerRole != null) dest.PractitionerRole = new List<Hl7.Fhir.Model.Practitioner.PractitionerPractitionerRoleComponent>(PractitionerRole.DeepCopy());
                if(Qualification != null) dest.Qualification = new List<Hl7.Fhir.Model.Practitioner.PractitionerQualificationComponent>(Qualification.DeepCopy());
                if(Communication != null) dest.Communication = new List<Hl7.Fhir.Model.CodeableConcept>(Communication.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Practitioner());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Practitioner;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if( !DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if( !DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if( !DeepComparable.Matches(PractitionerRole, otherT.PractitionerRole)) return false;
            if( !DeepComparable.Matches(Qualification, otherT.Qualification)) return false;
            if( !DeepComparable.Matches(Communication, otherT.Communication)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Practitioner;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if( !DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if( !DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if( !DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if( !DeepComparable.IsExactly(PractitionerRole, otherT.PractitionerRole)) return false;
            if( !DeepComparable.IsExactly(Qualification, otherT.Qualification)) return false;
            if( !DeepComparable.IsExactly(Communication, otherT.Communication)) return false;
            
            return true;
        }
        
    }
    
}
