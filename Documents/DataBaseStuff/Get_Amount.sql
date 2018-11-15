CREATE OR REPLACE FUNCTION 
Get_Amount (
	p_Username IN monei_user.Username%TYPE
	)
    RETURN monei_Account.CurrentAmount%TYPE
IS
    v_Amount monei_account.CurrentAmount%TYPE;
    v_UserId monei_user.UserId%TYPE;
BEGIN
    v_UserId := get_Userid(p_Username);
    SELECT CurrentAmount INTO v_Amount FROM monei_Account WHERE v_UserId = UserId;
    RETURN v_Amount;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        v_Amount := null; 
END;