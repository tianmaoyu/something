  
     with 
  --分组后的 7天前
  replyTable as (
     SELECT *, row_number() OVER ( partition BY ucid ORDER BY ReplyTime DESC) as number 
     FROM [Acadsoc.COM.CN].[dbo].[uc_UserComplainReply] 
     WHERE ReplyTime < dateadd(day,-7,GETDATE()) 
  ),
   --取按照 ucid 分组 取最后一条
   replyTable2 as(
    select a.UCID from replyTable a left join uc_UserComplain b on a.UCID=b.UCID where ID in (select MAX(number) from replyTable  group by UCID) and ReplyType=1 and b.Status=2
  )

   select * from replyTable2;

  --插入评价
  --insert into [Acadsoc.COM.CN].[dbo].[ComplaintSurvey](UCID, ComplaintType, CreateTime,ReplySpeedScore,ServiceAttitudeScore) 
  --   select ucid,0,ReplyAUID,GETDATE(),4,4 from replyTable2;
     
 --更新
