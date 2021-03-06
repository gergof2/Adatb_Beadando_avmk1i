create or replace procedure spInsert_boltok(
	p_nev in boltok.nev%type
)
authid definer
as
	v_id int;
begin
	select max(id) into v_id from boltok;

	if v_id is null then
		v_id := 0;
	end if;
	v_id := v_id + 1;

	insert into boltok
		(id, nev)
		values
		(v_id, p_nev);
end spInsert_boltok;