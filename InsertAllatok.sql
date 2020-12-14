create or replace procedure spInsert_allatok(
	p_idszam in allatok.idszam%type,
	p_faj in allatok.faj%type,
	p_nem in allatok.nem%type,
	p_etkezes in allatok.etkezes%type,
	p_ar in allatok.ar%type,
	p_bolt_id in boltok.nev%type,

	p_out_rowcnt out int
)

authid definer
as
	v_check_idszam int;
begin
	p_out_rowcnt := 0;

	if v_check_idszam = 1 then
		INSERT INTO allatok
			(idszam, faj, nem, etkezes, ar, bolt_id)
		VALUES
			(p_idszam, p_faj, p_nem, p_etkezes, p_ar, p_bolt_id);
		p_out_rowcnt := SQL%rowcount;
		commit;
	end if;
end spInsert_allatok;