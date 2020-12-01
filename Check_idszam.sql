create or replace function sfcheck_idszam(
	p_idszam in allatok.idszam%type
)
return int
deterministic

as
	v_idszam_int int(1);
	v_i int;
begin
	if p_idszam is null then
		return 0;
	end if;
	if lenght(trim(p_idszam)) = 4 then
		v_i := 1;
		while v_i <= 4 loop
			v_idszam_int := substr(p_idszam, v_i, 1);
			if not (ascii('0') <= ascii(v_idszam_int) and ascii(v_idszam_int) <= ascii('9')) then
			return 0;
			end if;
			v_i := v_i + 1;
		end loop;
		return 1;
	end if;
	return 0;
end sfcheck_idszam;