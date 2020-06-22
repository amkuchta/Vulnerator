﻿INSERT INTO UniqueFindings VALUES (
	NULL, 
	@InstanceIdentifier,
	@ToolGeneratedOutput, 
	@Comments, 
	@FindingDetails, 
	@FirstDiscovered, 
	@LastObserved, 
	@DeltaAnalysisRequired, 
	(SELECT FindingType_ID FROM FindingTypes WHERE FindingType = @FindingType), 
	(SELECT FindingSourceFile_ID FROM UniqueFindingsSourceFiles WHERE FindingSourceFileName = @FindingSourceFileName), 
	@Status, 
	(SELECT Vulnerability_ID FROM Vulnerabilities WHERE UniqueVulnerabilityIdentifier= @UniqueVulnerabilityIdentifier),
	(SELECT Hardware_ID FROM Hardware WHERE ScanIP = @ScanIP AND DiscoveredHostName = @DiscoveredHostName AND FQDN = @FQDN AND NetBIOS = @NetBIOS), 
	(SELECT Software_ID FROM Software WHERE DiscoveredSoftwareName = @DiscoveredSoftwareName) ,
	@SeverityOverride, 
	@SeverityOverrideJustification, 
	@TechnologyArea, 
	@WebDB_Site, 
	@WebDB_Instance, 
	@Classification, 
	@CVSS_EnvironmentalScore, 
	@CVSS_EnvironmentalVector,
	NULL);