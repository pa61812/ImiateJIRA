select * from UserRole

delete from UserRole

insert UserRole
values
     --rd
      ('rd','RS','system',GETDATE(),'system',GETDATE())
     ,('rd','UD','system',GETDATE(),'system',GETDATE())
	--qa
	 ,('qa','OP','system',GETDATE(),'system',GETDATE())
	 ,('qa','UD','system',GETDATE(),'system',GETDATE())
	 ,('qa','CL','system',GETDATE(),'system',GETDATE())


select * from UserRole