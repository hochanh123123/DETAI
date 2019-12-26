CREATE PROCEDURE [dbo].[SP_KTBANGDIEM]  
    @MASV NCHAR(8),
	@MAMH NCHAR(5),
	@LAN SMALLINT
AS  
BEGIN  
DECLARE @Result BIT  
IF EXISTS(SELECT * FROM dbo.BANGDIEM Where MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN)  
BEGIN
SET @Result=1  
END  
ELSE  
BEGIN  
SET @Result=0  
END  
SELECT @Result AS 'Result' 
END