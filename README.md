# AssetManagement
AssetManagement for System Center Service Manager 2012 R2
Visual Studio 2015 community solution and Orchestrator Runbook export.
Background information about this solution can be found on https://systemcentertipps.wordpress.com.

Folder Structure:
- AssetManagment: contains Visual Studio 2015 solution AssetManagement.sln
- Management Packs: contains SCSM management packs. I recommend to import them in the order AssetManagement.mpb, AssetManagementViews.mpb and then AssetManagementLists.xml
- Output: build during the solution build.
- Reports: SSRS reports which connect to the ServiceManager DB.
- Runbooks: Orchestrator runbook export file
