-----------------------------------------------------
--
--  Filename: script.txt
--
-----------------------------------------------------

-- This function does nothing of interest at all.
function DoNothing(bFlag)
	if bFlag == true then
		return true
	else
		return false
	end
end

-- Another useless function
function DoSomething(nValue)
	if nValue < 0 then
		return false
	elseif nValue > 0 then
		return true
	else
		return false
	end
end