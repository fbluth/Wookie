UPDATE [dbo].tsysCategory
   SET SvgImage = (SELECT  *  FROM OPENROWSET  ( BULK 'C:\Temp\SVG\265660-management\265660-management\svg\check-mark.svg',SINGLE_CLOB) AS Document)
   WHERE PKCategory = 4
GO

UPDATE [dbo].tsysCategory
   SET SvgImage = (SELECT  *  FROM OPENROWSET  ( BULK 'C:\Temp\SVG\265660-management\265660-management\svg\id-card.svg',SINGLE_CLOB) AS Document)
   WHERE PKCategory = 2
GO

UPDATE [dbo].tsysCategory
   SET SvgImage = (SELECT  *  FROM OPENROWSET  ( BULK 'C:\Temp\SVG\265660-management\265660-management\svg\office-material-2.svg',SINGLE_CLOB) AS Document)
   WHERE PKCategory = 5
GO

UPDATE [dbo].tsysCategory
   SET SvgImage = (SELECT  *  FROM OPENROWSET  ( BULK 'C:\Temp\SVG\265660-management\265660-management\svg\wall-calendar.svg',SINGLE_CLOB) AS Document)
   WHERE PKCategory = 3
GO

UPDATE [dbo].tsysClient
   SET SvgImage = (SELECT  *  FROM OPENROWSET  ( BULK 'C:\Temp\SVG\265660-management\265660-management\png\finances.png',SINGLE_CLOB) AS Document)
   WHERE PKClient = 3
GO