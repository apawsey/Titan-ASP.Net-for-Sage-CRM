<!-- #include file ="SageCRM.js" -->
<%
//******************************************************************************
//******************************************************************************
/*
*  TITAN ASP.NET for Sage CRM
*/
//******************************************************************************
try{
  var TableName=new String(Request.QueryString('TableName'));
  var WhereClause=new String(Request.QueryString('WhereClause'));
  //Top is used by data aware controls
  //how many records to display in a data enabled control
  var Top=new Number(Request.QueryString('Top'));
  //iTop is used when coding
  var iTop=new Number(Request.QueryString('iTop'));
  //where to display data from.
  var iFrom=new Number(Request.QueryString('iFrom'));
/*  
//s  test code
  
  TableName="Company";
 // iFrom=10;
  iTop=1;
  WhereClause="comp_companyid<100";
  */  
  debugcrm("findrecord_qs", Request.QueryString);
  if (!Defined(WhereClause)){
    WhereClause="";
  }
  if ((iTop!="") && (Defined(iTop)))
  {
    Top=iTop;
  }  
  if (isNaN(Top)){
    Top=-1;
  }
  if (isNaN(iFrom)){
    iFrom=-1;
  }

  var fieldarr=new Array();
  var fieldtype=new Array();
  var result="<?xml version=\"1.0\" standalone=\"yes\"?>";
  result+="<data>";
  var record=eWare.FindRecord(TableName,WhereClause);

  try
  {
    var fieldrec = eWare.CreateQueryObj("select top 1 * from "+TableName);    
    fieldrec.SelectSQL();
    eQueryFields = new Enumerator(fieldrec);
    while (!eQueryFields.atEnd()) {
      var fieldx=new String(eQueryFields.item());
      fieldx=fieldx.toLowerCase();
      fieldarr[fieldarr.length]=fieldx;
      etype=new String("10");
      fieldtype[fieldarr.length]=etype.substr(0,2);
      eQueryFields.moveNext();
    }  
  }catch(e)
  {   //for external tables and views we use the metadata in crm
    var fieldrec = eWare.CreateQueryObj("select colp_colname, colp_entrytype from custom_edits where ColP_Entity = '"+TableName+ "'"+
                     " and ((colp_system is null) or (colp_system='')) ORDER BY ColP_ColPropsId");
    fieldrec.SelectSQL();
    while (!fieldrec.eof){
      fieldarr[fieldarr.length]=fieldrec("colp_colname");
      etype=new String(fieldrec("colp_entrytype"));
      fieldtype[fieldarr.length]=etype.substr(0,2);
      fieldrec.NextRecord();
    } 
  }
  iTopCount=0;
  iRowCount=0;
  while (!record.eof)
  {
      iRowCount++;
      if  ( (iFrom==-1) || (iFrom<iRowCount) )
      {
        if ( (Top==-1) || (Top==0) ||(iTopCount<Top) ){
          result+="<"+TableName+">";
          result+="<"+record.idfield+">"+record[record.idfield]+"</"+record.idfield+">";
          for(i=0;i<fieldarr.length;i++){
            fieldval=record[fieldarr[i]];
            if (!Defined(record[fieldarr[i]])){
              fieldval="";
              if (i==0)  //fix for when the data in the first column is blank...breaks xml 
                fieldval="_";
            }
            fieldName=new String(fieldarr[i]);
            fieldName=fieldName.replace(/\s/g, '');    
            if (record.idfield!=fieldarr[i])
              result+="<"+fieldName+">"+CustomEscape(fieldval)+"</"+fieldName+">";
          }
          result+="</"+TableName+">";
        }
        iTopCount++;
      }
      record.NextRecord();
  }
  //add the total row count info now
  result+="<crmtogethertrc>";
  result+="<crmtogethertotal>"+iRowCount;  
  result+="</crmtogethertotal>";    
  result+="</crmtogethertrc>";
  result+="</data>";
  Response.Write(result);
  debugcrm("findrecord", result);
  Response.End();
}catch(e){
  logerror(e);
}

function _getuser(uid){
  if (((Defined(uid)) && (uid!='')) && (!isNaN(uid))) {
    var urec=eWare.FindRecord("Users","user_userid="+uid);
    return urec("user_firstname")+" "+urec("user_lastname");
  }
  return '';
}
%>