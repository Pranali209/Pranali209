-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[AdminLoginFunction]
(
	-- Add the parameters for the function here
	@p_aid varchar(50),
	@p_pwd varchar(50)

)
RETURNS bit
AS
BEGIN
	-- Declare the return variable here
	DECLARE @status bit,
	@v_aid varchar(50),
	@v_pwd varchar(50)

	-- Add the T-SQL statements to compute the return value here
	 select @v_aid = AdminId ,@v_pwd = AdminPassword from AdminLogin
	  if(@p_aid = @v_aid)
	  begin
	     set  @status = 1
	  end 
	   else
	   begin
	      set @status = 0
	   end 
	-- Return the result of the function
	RETURN @status 

END
GO

