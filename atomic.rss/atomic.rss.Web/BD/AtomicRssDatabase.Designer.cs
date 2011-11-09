﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AtomicRssDatabase", "ChannelsArticles", "Channels", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(atomic.rss.Web.BD.Channels), "Articles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(atomic.rss.Web.BD.Articles))]
[assembly: EdmRelationshipAttribute("AtomicRssDatabase", "UsersChannels", "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(atomic.rss.Web.BD.Users), "Channels", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(atomic.rss.Web.BD.Channels))]
[assembly: EdmRelationshipAttribute("AtomicRssDatabase", "UsersArticles", "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(atomic.rss.Web.BD.Users), "Articles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(atomic.rss.Web.BD.Articles))]

#endregion

namespace atomic.rss.Web.BD
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AtomicRssDatabaseContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AtomicRssDatabaseContainer object using the connection string found in the 'AtomicRssDatabaseContainer' section of the application configuration file.
        /// </summary>
        public AtomicRssDatabaseContainer() : base("name=AtomicRssDatabaseContainer", "AtomicRssDatabaseContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AtomicRssDatabaseContainer object.
        /// </summary>
        public AtomicRssDatabaseContainer(string connectionString) : base(connectionString, "AtomicRssDatabaseContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AtomicRssDatabaseContainer object.
        /// </summary>
        public AtomicRssDatabaseContainer(EntityConnection connection) : base(connection, "AtomicRssDatabaseContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Channels> ChannelsSet
        {
            get
            {
                if ((_ChannelsSet == null))
                {
                    _ChannelsSet = base.CreateObjectSet<Channels>("ChannelsSet");
                }
                return _ChannelsSet;
            }
        }
        private ObjectSet<Channels> _ChannelsSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Users> UsersSet
        {
            get
            {
                if ((_UsersSet == null))
                {
                    _UsersSet = base.CreateObjectSet<Users>("UsersSet");
                }
                return _UsersSet;
            }
        }
        private ObjectSet<Users> _UsersSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Articles> ArticlesSet
        {
            get
            {
                if ((_ArticlesSet == null))
                {
                    _ArticlesSet = base.CreateObjectSet<Articles>("ArticlesSet");
                }
                return _ArticlesSet;
            }
        }
        private ObjectSet<Articles> _ArticlesSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ChannelsSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToChannelsSet(Channels channels)
        {
            base.AddObject("ChannelsSet", channels);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UsersSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsersSet(Users users)
        {
            base.AddObject("UsersSet", users);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ArticlesSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToArticlesSet(Articles articles)
        {
            base.AddObject("ArticlesSet", articles);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AtomicRssDatabase", Name="Articles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Articles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Articles object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="link">Initial value of the Link property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        /// <param name="gUID">Initial value of the GUID property.</param>
        public static Articles CreateArticles(global::System.Int32 id, global::System.String title, global::System.String link, global::System.String description, global::System.DateTime date, global::System.String gUID)
        {
            Articles articles = new Articles();
            articles.Id = id;
            articles.Title = title;
            articles.Link = link;
            articles.Description = description;
            articles.Date = date;
            articles.GUID = gUID;
            return articles;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Link
        {
            get
            {
                return _Link;
            }
            set
            {
                OnLinkChanging(value);
                ReportPropertyChanging("Link");
                _Link = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Link");
                OnLinkChanged();
            }
        }
        private global::System.String _Link;
        partial void OnLinkChanging(global::System.String value);
        partial void OnLinkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String GUID
        {
            get
            {
                return _GUID;
            }
            set
            {
                OnGUIDChanging(value);
                ReportPropertyChanging("GUID");
                _GUID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("GUID");
                OnGUIDChanged();
            }
        }
        private global::System.String _GUID;
        partial void OnGUIDChanging(global::System.String value);
        partial void OnGUIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "ChannelsArticles", "Channels")]
        public Channels Channels
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Channels>("AtomicRssDatabase.ChannelsArticles", "Channels").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Channels>("AtomicRssDatabase.ChannelsArticles", "Channels").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Channels> ChannelsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Channels>("AtomicRssDatabase.ChannelsArticles", "Channels");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Channels>("AtomicRssDatabase.ChannelsArticles", "Channels", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "UsersArticles", "Users")]
        public EntityCollection<Users> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Users>("AtomicRssDatabase.UsersArticles", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Users>("AtomicRssDatabase.UsersArticles", "Users", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AtomicRssDatabase", Name="Channels")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Channels : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Channels object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="link">Initial value of the Link property.</param>
        /// <param name="language">Initial value of the Language property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="updateFrequency">Initial value of the UpdateFrequency property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static Channels CreateChannels(global::System.Int32 id, global::System.String title, global::System.String description, global::System.String link, global::System.String language, global::System.String author, global::System.Int32 updateFrequency, global::System.DateTime date)
        {
            Channels channels = new Channels();
            channels.Id = id;
            channels.Title = title;
            channels.Description = description;
            channels.Link = link;
            channels.Language = language;
            channels.Author = author;
            channels.UpdateFrequency = updateFrequency;
            channels.Date = date;
            return channels;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Link
        {
            get
            {
                return _Link;
            }
            set
            {
                OnLinkChanging(value);
                ReportPropertyChanging("Link");
                _Link = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Link");
                OnLinkChanged();
            }
        }
        private global::System.String _Link;
        partial void OnLinkChanging(global::System.String value);
        partial void OnLinkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Language
        {
            get
            {
                return _Language;
            }
            set
            {
                OnLanguageChanging(value);
                ReportPropertyChanging("Language");
                _Language = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Language");
                OnLanguageChanged();
            }
        }
        private global::System.String _Language;
        partial void OnLanguageChanging(global::System.String value);
        partial void OnLanguageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UpdateFrequency
        {
            get
            {
                return _UpdateFrequency;
            }
            set
            {
                OnUpdateFrequencyChanging(value);
                ReportPropertyChanging("UpdateFrequency");
                _UpdateFrequency = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UpdateFrequency");
                OnUpdateFrequencyChanged();
            }
        }
        private global::System.Int32 _UpdateFrequency;
        partial void OnUpdateFrequencyChanging(global::System.Int32 value);
        partial void OnUpdateFrequencyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "ChannelsArticles", "Articles")]
        public EntityCollection<Articles> Articles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Articles>("AtomicRssDatabase.ChannelsArticles", "Articles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Articles>("AtomicRssDatabase.ChannelsArticles", "Articles", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "UsersChannels", "Users")]
        public EntityCollection<Users> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Users>("AtomicRssDatabase.UsersChannels", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Users>("AtomicRssDatabase.UsersChannels", "Users", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AtomicRssDatabase", Name="Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Users : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Users object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="passwords">Initial value of the Passwords property.</param>
        /// <param name="isAdmin">Initial value of the IsAdmin property.</param>
        public static Users CreateUsers(global::System.Int32 id, global::System.String email, global::System.String passwords, global::System.Boolean isAdmin)
        {
            Users users = new Users();
            users.Id = id;
            users.Email = email;
            users.Passwords = passwords;
            users.IsAdmin = isAdmin;
            return users;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Passwords
        {
            get
            {
                return _Passwords;
            }
            set
            {
                OnPasswordsChanging(value);
                ReportPropertyChanging("Passwords");
                _Passwords = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Passwords");
                OnPasswordsChanged();
            }
        }
        private global::System.String _Passwords;
        partial void OnPasswordsChanging(global::System.String value);
        partial void OnPasswordsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAdmin
        {
            get
            {
                return _IsAdmin;
            }
            set
            {
                OnIsAdminChanging(value);
                ReportPropertyChanging("IsAdmin");
                _IsAdmin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAdmin");
                OnIsAdminChanged();
            }
        }
        private global::System.Boolean _IsAdmin;
        partial void OnIsAdminChanging(global::System.Boolean value);
        partial void OnIsAdminChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "UsersChannels", "Channels")]
        public EntityCollection<Channels> Channels
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Channels>("AtomicRssDatabase.UsersChannels", "Channels");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Channels>("AtomicRssDatabase.UsersChannels", "Channels", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AtomicRssDatabase", "UsersArticles", "Articles")]
        public EntityCollection<Articles> Articles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Articles>("AtomicRssDatabase.UsersArticles", "Articles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Articles>("AtomicRssDatabase.UsersArticles", "Articles", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
