create or replace procedure sfGet_BoltId(
	p_nev in boltok.nev%type
)
return int
deterministic

as
	temp int;
	temp_cnt int;
begin
	select count(*) into temp_cnt FROM boltok where nev = p_nev;

	if temp_cnt = 0 then
		return null;
	else
		SELECT id into temp from boltok where nev = p_nev;
	end if;

	return temp;
	
end sfGet_BoltId;