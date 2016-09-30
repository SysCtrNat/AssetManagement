# AssetManagement
AssetManagement for System Center Service Manager 2012 R2 and Orchestrator Runbook export.
Background information about this solution can be found here: https://systemcentertipps.wordpress.com/2016/09/23/scsm-2012-asset-management.

Folder Structure:
- Management Packs: contains SCSM management packs. I recommend to import them in the order AssetManagement.mpb, AssetManagementViews.mpb and then AssetManagementLists.xml
- Reports: SSRS reports which connect to the ServiceManager DB.
- Runbooks: Orchestrator runbook export file
