CREATE OR REPLACE FUNCTION 
Get_Password (
	p_Username IN monei_user.Username%TYPE,
    p_Password OUT monei_user.Password%TYPE
	)
AS
BEGIN
    SELECT password INTO p_Password FROM monei_user WHERE p_Username = username;
END;