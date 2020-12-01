set serveroutput on;
declare
	v_call_idszam int;
	v_idszam allatok.idszam%type := '0001';
begin
	v_call_idszam := sfcheck_idszam(v_idszam);

	if v_call_idszam = 1 then
		DBMS_OUTPUT.PUT_LINE('Az alábbi id helyes: '||v_idszam);
	else
		DBMS_OUTPUT.PUT_LINE('Az alábbi id helytelen: '||v_idszam);
	end if;
end;