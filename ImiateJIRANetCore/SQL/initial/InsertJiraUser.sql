select * from JiraUser

truncate table JiraUser

insert into JiraUser
values('rd','rd',null,null,'system',getdate(),'system',getdate()),
      ('qa','qa',null,null,'system',getdate(),'system',getdate())

select * from JiraUser