use master
create database DB_Clinic;
go 

use DB_Clinic
go 
CREATE TABLE Docteur(
    D_id bigint IDENTITY(1,1) primary key ,
    D_Cin varchar(8) ,
    D_Nom varchar(15) ,
    D_Prenom varchar(15) ,
    D_Telephone char(10) ,
    D_Adresse varchar(30) ,
    D_Email varchar(30) ,
    Departement varchar(20) ,
    Specialite varchar(20) ,
    DateEmbauche date ,
	)
	
create table Patient (
	ID bigint Primary key IDENTITY(1,1),
	nom varchar (15),
	prenom varchar (15),
	sexe char(1),
	cin  char(8),
	datenaissance  Date,
	telephone char(10),
	situationfamiliale varchar (12),
	mutuelle varchar(10),
	adresse varchar(25),
	datedecreation Date,
	docteurID int 
)
alter table Patient 
add constraint fk_docteurID foreign key (docteurID) references Docteur(D_id),
check (sexe in ('M','F'))

create table RDV(
RDVid bigint primary key IDENTITY(1,1),
patientID bigint,
dateRDV date,
heureRDV time,
motif varchar(10),
)

alter table RDV 
add constraint fk_patientID foreign key (patientID) references Patient(ID)

create table Antecedents(
	ID bigint primary key IDENTITY(1,1),
	patientID  bigint,
	typeAntecedents varchar(20),
	antecedents varchar(20),
	commentaire varchar(20),
)
alter table Antecedents 
add constraint fk_rdvpatientID foreign key (patientID) references Patient(ID)

create table Visite(
	ID  bigint primary key IDENTITY(1,1),
	patientID  bigint,
	interrogatoire varchar(30),
	conclusion	varchar(30),
	examen varchar(30),
	traitement varchar(30),
	montant int ,
	estPayer char(3)
)
alter table Visite 
add constraint fk_v_docteurID foreign key (docteurID) references Docteur(D_id),
constraint fk_v_patientID foreign key (patientID) references Patient(ID)

create table medicament(
	medicamentid bigint primary key IDENTITY(1,1),
	medicament varchar(35)
)

create table Ordonnance(
	id bigint primary key IDENTITY(1,1),
	medicamentid bigint,
	prise varchar(15),
	periode  varchar(15),
	nbparjours  int,
	quand  varchar(10),
	remarque varchar(14)
)
alter table Ordonnance 
add constraint fk_medicamentid foreign key (medicamentid) references medicament(medicamentid)

create table laboratoire(
 testnum bigint primary key identity(1,1),
 pid bigint, 
 testnom varchar(10),
 testprix int
)
alter table laboratoire
add constraint fk_l_patientID foreign key (pid) references Patient(ID)
--proc regler rdv
create proc reglerRDV @pid bigint ,@daterdv date,@heure time ,@motif varchar(10)
as
BEGIN  
 insert into RDV(patientID,dateRDV,heureRDV,motif) values (@pid,@daterdv,@heure,@motif)
 end
 --proc ajouter l'antecedents
 create proc ajouterLANT @pid bigint ,@typeant varchar(20),@ant varchar(20) ,@Com varchar(20)
as
BEGIN  
 insert into Antecedents(patientID,typeAntecedents,antecedents,commentaire) values (@pid,@typeant,@ant,@Com)
end
 -- proc Valider visite
 create proc ValiderVisite 
 @pid bigint,@interrogatoire varchar(30),@conclusion varchar(30) ,@examen varchar(30),@traitement varchar(30),@montant int,@estPayer char(3)
 as 
 begin
    insert into Visite(patientID,interrogatoire,conclusion,examen,traitement,montant,estPayer)values (@pid,@interrogatoire,@conclusion,@examen,@traitement,@montant,@estPayer)
 end 
 -- proc prescrit 
 create proc prescrit 
       @medicamentid bigint
       ,@prise varchar(15)
      ,@periode varchar(15)
      ,@nbparjours int 
      ,@quand varchar(10)
      ,@remarque varchar(14)
	  as 
	  begin
	  INSERT INTO Ordonnance(medicamentid
       ,prise
      ,periode
      ,nbparjours
      ,quand
      ,remarque) values ( @medicamentid
       ,@prise
      ,@periode
      ,@nbparjours
      ,@quand
      ,@remarque
	  )
	  end 

-- trigger supprimer Docteur (Updated)


   create Trigger [dbo].[TriggerDo]
   On [dbo].[Docteur]
   instead of delete
   as begin
   if exists (select * from deleted where D_id in(select D_id from Docteur))
   delete from RDV where patientID IN (Select ID FROM Patient WHERE docteurID IN(SELECT D_id from deleted))
   delete from Patient where docteurID IN (SELECT D_id from deleted)
   end

