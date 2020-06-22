﻿UPDATE UniqueFindings SET 
	FindingDetails = @FindingDetails, 
	Comments = @Comments, 
	SeverityOverride = @SeverityOverride, 
	SeverityOverrideJustification = @SeverityOverrideJustification, 
	LastObserved = @LastObserved, 
	TechnologyArea = @TechnologyArea, 
	WebDB_Site = @WebDB_Site, 
	WebDB_Instance = @WebDB_Instance, 
	FindingSourceFile_ID = (SELECT FindingSourceFile_ID FROM UniqueFindingsSourceFiles WHERE FindingSourceFileName = @FindingSourceFileName), 
	Status = @Status,  
	ToolGeneratedOutput = @ToolGeneratedOutput 
WHERE 
	Hardware_ID = (SELECT Hardware_ID FROM Hardware WHERE ScanIP = @ScanIP) 
AND 
	Vulnerability_ID = (SELECT Vulnerability_ID FROM Vulnerabilities WHERE UniqueVulnerabilityIdentifier = @UniqueVulnerabilityIdentifier) 
AND 
	LastObserved < @LastObserved;