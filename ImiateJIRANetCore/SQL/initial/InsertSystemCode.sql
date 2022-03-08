select * from SystemCode

delete from SystemCode

insert SystemCode
values
     --Jira狀態
      ('JiraStatus','NS','未處理',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
     ,('JiraStatus','DO','處理中',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 ,('JiraStatus','FN','已解決',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 ,('JiraStatus','CL','已關閉',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 --Jira權限
	 ,('JiraRole','OP','開單',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 ,('JiraRole','RS','解決',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 ,('JiraRole','UD','更新',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())
	 ,('JiraRole','CL','關單',GETDATE(),'','','','','system',GETDATE(),'system',GETDATE())


select * from SystemCode







