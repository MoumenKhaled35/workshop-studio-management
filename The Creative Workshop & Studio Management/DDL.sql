/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/7/2026 4:39:31 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGISTRATION') and o.name = 'FK_REGISTRA_REGISTRAT_WORKSHOP')
alter table REGISTRATION
   drop constraint FK_REGISTRA_REGISTRAT_WORKSHOP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGISTRATION') and o.name = 'FK_REGISTRA_REGISTRAT_MEMBER')
alter table REGISTRATION
   drop constraint FK_REGISTRA_REGISTRAT_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTAL') and o.name = 'FK_RENTAL_RENTAL_MEMBER')
alter table RENTAL
   drop constraint FK_RENTAL_RENTAL_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTAL') and o.name = 'FK_RENTAL_RENTAL2_TOOL')
alter table RENTAL
   drop constraint FK_RENTAL_RENTAL2_TOOL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TOOL') and o.name = 'FK_TOOL_CONTAINS_STUDIO')
alter table TOOL
   drop constraint FK_TOOL_CONTAINS_STUDIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WORKSHOP') and o.name = 'FK_WORKSHOP_HOSTS_STUDIO')
alter table WORKSHOP
   drop constraint FK_WORKSHOP_HOSTS_STUDIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WORKSHOP') and o.name = 'FK_WORKSHOP_TEACHES_ARTIST')
alter table WORKSHOP
   drop constraint FK_WORKSHOP_TEACHES_ARTIST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WORKSHOPMATERIAL') and o.name = 'FK_WORKSHOP_WORKSHOPM_MATERIAL')
alter table WORKSHOPMATERIAL
   drop constraint FK_WORKSHOP_WORKSHOPM_MATERIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WORKSHOPMATERIAL') and o.name = 'FK_WORKSHOP_WORKSHOPM_WORKSHOP')
alter table WORKSHOPMATERIAL
   drop constraint FK_WORKSHOP_WORKSHOPM_WORKSHOP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ARTIST')
            and   type = 'U')
   drop table ARTIST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MATERIAL')
            and   type = 'U')
   drop table MATERIAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEMBER')
            and   type = 'U')
   drop table MEMBER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGISTRATION')
            and   name  = 'REGISTRATION2_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGISTRATION.REGISTRATION2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGISTRATION')
            and   name  = 'REGISTRATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGISTRATION.REGISTRATION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGISTRATION')
            and   type = 'U')
   drop table REGISTRATION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTAL')
            and   name  = 'RENTAL2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTAL.RENTAL2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTAL')
            and   name  = 'RENTAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTAL.RENTAL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENTAL')
            and   type = 'U')
   drop table RENTAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDIO')
            and   type = 'U')
   drop table STUDIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TOOL')
            and   name  = 'CONTAINS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TOOL.CONTAINS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TOOL')
            and   type = 'U')
   drop table TOOL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKSHOP')
            and   name  = 'TEACHES_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKSHOP.TEACHES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKSHOP')
            and   name  = 'HOSTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKSHOP.HOSTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WORKSHOP')
            and   type = 'U')
   drop table WORKSHOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKSHOPMATERIAL')
            and   name  = 'WORKSHOPMATERIAL2_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKSHOPMATERIAL.WORKSHOPMATERIAL2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WORKSHOPMATERIAL')
            and   name  = 'WORKSHOPMATERIAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index WORKSHOPMATERIAL.WORKSHOPMATERIAL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WORKSHOPMATERIAL')
            and   type = 'U')
   drop table WORKSHOPMATERIAL
go

/*==============================================================*/
/* Table: ARTIST                                                */
/*==============================================================*/
create table ARTIST (
   ARTISTID             int                  not null,
   SPECIALTY            varchar(100)         null,
   EXPERIENCEYEARS      int                  null,
   ARTISTNAME           varchar(100)         null,
   constraint PK_ARTIST primary key nonclustered (ARTISTID)
)
go

/*==============================================================*/
/* Table: MATERIAL                                              */
/*==============================================================*/
create table MATERIAL (
   MATERIAL_ID          int                  not null,
   QUANTITYAVAILABLE    decimal(10,2)        null,
   UNIT                 varchar(50)          null,
   MATERIALNAME         varchar(100)         null,
   constraint PK_MATERIAL primary key nonclustered (MATERIAL_ID)
)
go

/*==============================================================*/
/* Table: MEMBER                                                */
/*==============================================================*/
create table MEMBER (
   MEMBER_ID            int                  not null,
   EMAIL                varchar(150)         null,
   PHONENUM             varchar(20)          null,
   SUBFEE               decimal(10,2)        null,
   SUBSTARTDATE         datetime             null,
   MEMBERNAME           varchar(100)         null,
   constraint PK_MEMBER primary key nonclustered (MEMBER_ID)
)
go

/*==============================================================*/
/* Table: REGISTRATION                                          */
/*==============================================================*/
create table REGISTRATION (
   WORKSHOP_ID          int                  not null,
   MEMBER_ID            int                  not null,
   REGISTRATIONID       int                  not null,
   REGISTRATIONDATE     datetime             null,
   constraint PK_REGISTRATION primary key (REGISTRATIONID)
)
go

/*==============================================================*/
/* Index: REGISTRATION_FK                                       */
/*==============================================================*/
create index REGISTRATION_FK on REGISTRATION (
WORKSHOP_ID ASC
)
go

/*==============================================================*/
/* Index: REGISTRATION2_FK                                      */
/*==============================================================*/
create index REGISTRATION2_FK on REGISTRATION (
MEMBER_ID ASC
)
go

/*==============================================================*/
/* Table: RENTAL                                                */
/*==============================================================*/
create table RENTAL (
   MEMBER_ID            int                  not null,
   TOOLID               int                  not null,
   RENTALID             int                  not null,
   PICKUPTIME           datetime            null,
   RETURNCONDITION      varchar(50)          null,
   constraint PK_RENTAL primary key (RENTALID)
)
go

/*==============================================================*/
/* Index: RENTAL_FK                                             */
/*==============================================================*/
create index RENTAL_FK on RENTAL (
MEMBER_ID ASC
)
go

/*==============================================================*/
/* Index: RENTAL2_FK                                            */
/*==============================================================*/
create index RENTAL2_FK on RENTAL (
TOOLID ASC
)
go

/*==============================================================*/
/* Table: STUDIO                                                */
/*==============================================================*/
create table STUDIO (
   STUDIOID             int                  not null,
   MAXCAPACITY          int                  null,
   STUDIONAME           varchar(100)         null,
   constraint PK_STUDIO primary key nonclustered (STUDIOID)
)
go

/*==============================================================*/
/* Table: TOOL                                                  */
/*==============================================================*/
create table TOOL (
   TOOLID               int                  not null,
   STUDIOID             int                  not null,
   DESCRIPTION          varchar(255)         null,
   CONDITION            varchar(50)          null,
   AVAILABILITYSTATUS   varchar(50)          null,
   TOOLNAME             varchar(100)         null,
   constraint PK_TOOL primary key nonclustered (TOOLID)
)
go

/*==============================================================*/
/* Index: CONTAINS_FK                                           */
/*==============================================================*/
create index CONTAINS_FK on TOOL (
STUDIOID ASC
)
go

/*==============================================================*/
/* Table: WORKSHOP                                              */
/*==============================================================*/
create table WORKSHOP (
   WORKSHOP_ID          int                  not null,
   ARTISTID             int                  not null,
   STUDIOID             int                  not null,
   CRAFT                varchar(100)         null,
   WORKSHOPDATE         datetime             null,
   WORKSHOPTIME         time             null,
   DURATION             int                  null,
   constraint PK_WORKSHOP primary key nonclustered (WORKSHOP_ID)
)
go

/*==============================================================*/
/* Index: HOSTS_FK                                              */
/*==============================================================*/
create index HOSTS_FK on WORKSHOP (
STUDIOID ASC
)
go

/*==============================================================*/
/* Index: TEACHES_FK                                            */
/*==============================================================*/
create index TEACHES_FK on WORKSHOP (
ARTISTID ASC
)
go

/*==============================================================*/
/* Table: WORKSHOPMATERIAL                                      */
/*==============================================================*/
create table WORKSHOPMATERIAL (
   MATERIAL_ID          int                  not null,
   WORKSHOP_ID          int                  not null,
   QUANTITYUSED         decimal(10,2)        null,
   constraint PK_WORKSHOPMATERIAL primary key (MATERIAL_ID, WORKSHOP_ID)
)
go

/*==============================================================*/
/* Index: WORKSHOPMATERIAL_FK                                   */
/*==============================================================*/
create index WORKSHOPMATERIAL_FK on WORKSHOPMATERIAL (
MATERIAL_ID ASC
)
go

/*==============================================================*/
/* Index: WORKSHOPMATERIAL2_FK                                  */
/*==============================================================*/
create index WORKSHOPMATERIAL2_FK on WORKSHOPMATERIAL (
WORKSHOP_ID ASC
)
go

alter table REGISTRATION
   add constraint FK_REGISTRA_REGISTRAT_WORKSHOP foreign key (WORKSHOP_ID)
      references WORKSHOP (WORKSHOP_ID)
go

alter table REGISTRATION
   add constraint FK_REGISTRA_REGISTRAT_MEMBER foreign key (MEMBER_ID)
      references MEMBER (MEMBER_ID)
go

alter table RENTAL
   add constraint FK_RENTAL_RENTAL_MEMBER foreign key (MEMBER_ID)
      references MEMBER (MEMBER_ID)
go

alter table RENTAL
   add constraint FK_RENTAL_RENTAL2_TOOL foreign key (TOOLID)
      references TOOL (TOOLID)
go

alter table TOOL
   add constraint FK_TOOL_CONTAINS_STUDIO foreign key (STUDIOID)
      references STUDIO (STUDIOID)
go

alter table WORKSHOP
   add constraint FK_WORKSHOP_HOSTS_STUDIO foreign key (STUDIOID)
      references STUDIO (STUDIOID)
go

alter table WORKSHOP
   add constraint FK_WORKSHOP_TEACHES_ARTIST foreign key (ARTISTID)
      references ARTIST (ARTISTID)
go

alter table WORKSHOPMATERIAL
   add constraint FK_WORKSHOP_WORKSHOPM_MATERIAL foreign key (MATERIAL_ID)
      references MATERIAL (MATERIAL_ID)
go

alter table WORKSHOPMATERIAL
   add constraint FK_WORKSHOP_WORKSHOPM_WORKSHOP foreign key (WORKSHOP_ID)
      references WORKSHOP (WORKSHOP_ID)
go

