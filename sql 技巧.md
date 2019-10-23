 :select into  临时表
 SELECT TOP 10 * into #temp FROM [Acadsoc.COM.CN].[dbo].[uc_UserComplain]
     
     select * from #temp
