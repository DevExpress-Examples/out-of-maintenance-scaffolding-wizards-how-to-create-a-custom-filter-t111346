<!-- default file list -->
*Files to look at*:

* [Issue.cs](./CS/Scaffolding.CustomFilter/Data/Issue.cs) (VB: [IssueContext.vb](./VB/Scaffolding.CustomFilter/Data/IssueContext.vb))
* [IssueContext.cs](./CS/Scaffolding.CustomFilter/Data/IssueContext.cs) (VB: [IssueContext.vb](./VB/Scaffolding.CustomFilter/Data/IssueContext.vb))
* [IssueContextInitializer.cs](./CS/Scaffolding.CustomFilter/Data/IssueContextInitializer.cs) (VB: [IssueContextInitializer.vb](./VB/Scaffolding.CustomFilter/Data/IssueContextInitializer.vb))
* [IssueType.cs](./CS/Scaffolding.CustomFilter/Data/IssueType.cs) (VB: [IssueType.vb](./VB/Scaffolding.CustomFilter/Data/IssueType.vb))
* [DesignTimeIssueContextUnitOfWork.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/DesignTime/DesignTimeIssueContextUnitOfWork.cs) (VB: [DesignTimeIssueContextUnitOfWork.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/DesignTime/DesignTimeIssueContextUnitOfWork.vb))
* [DesignTimeIssueRepository.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/DesignTime/DesignTimeIssueRepository.cs) (VB: [DesignTimeIssueRepository.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/DesignTime/DesignTimeIssueRepository.vb))
* [IIssueContextUnitOfWork.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/Model/IIssueContextUnitOfWork.cs) (VB: [IIssueContextUnitOfWork.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/Model/IIssueContextUnitOfWork.vb))
* [IIssueRepository.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/Model/IIssueRepository.cs) (VB: [IIssueRepository.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/Model/IIssueRepository.vb))
* [IssueContextUnitOfWork.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/Runtime/IssueContextUnitOfWork.cs) (VB: [IssueContextUnitOfWork.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/Runtime/IssueContextUnitOfWork.vb))
* [IssueRepository.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/Runtime/IssueRepository.cs) (VB: [IssueRepository.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/Runtime/IssueRepository.vb))
* [UnitOfWorkSource.cs](./CS/Scaffolding.CustomFilter/IssueContextDataModel/UnitOfWorkSource.cs) (VB: [UnitOfWorkSource.vb](./VB/Scaffolding.CustomFilter/IssueContextDataModel/UnitOfWorkSource.vb))
* [IssueContextView.xaml](./CS/Scaffolding.CustomFilter/IssueContextView.xaml) (VB: [IssueContextView.xaml](./VB/Scaffolding.CustomFilter/IssueContextView.xaml))
* [IssueContextView.xaml.cs](./CS/Scaffolding.CustomFilter/IssueContextView.xaml.cs) (VB: [IssueContextView.xaml.vb](./VB/Scaffolding.CustomFilter/IssueContextView.xaml.vb))
* [IssueContextViewModel.cs](./CS/Scaffolding.CustomFilter/IssueContextViewModel.cs) (VB: [IssueContextViewModel.vb](./VB/Scaffolding.CustomFilter/IssueContextViewModel.vb))
* [MainWindow.xaml](./CS/Scaffolding.CustomFilter/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Scaffolding.CustomFilter/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Scaffolding.CustomFilter/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Scaffolding.CustomFilter/MainWindow.xaml.vb))
* [IssueCollectionViewModel.cs](./CS/Scaffolding.CustomFilter/ViewModels/IssueCollectionViewModel.cs) (VB: [IssueCollectionViewModel.vb](./VB/Scaffolding.CustomFilter/ViewModels/IssueCollectionViewModel.vb))
* [IssueCollectionViewModel.Extensions.cs](./CS/Scaffolding.CustomFilter/ViewModels/IssueCollectionViewModel.Extensions.cs) (VB: [IssueCollectionViewModel.Extensions.vb](./VB/Scaffolding.CustomFilter/ViewModels/IssueCollectionViewModel.Extensions.vb))
* [IssueViewModel.cs](./CS/Scaffolding.CustomFilter/ViewModels/IssueViewModel.cs) (VB: [IssueViewModel.vb](./VB/Scaffolding.CustomFilter/ViewModels/IssueViewModel.vb))
* [IssueCollectionView.xaml](./CS/Scaffolding.CustomFilter/Views/IssueCollectionView.xaml) (VB: [IssueCollectionView.xaml](./VB/Scaffolding.CustomFilter/Views/IssueCollectionView.xaml))
* [IssueCollectionView.xaml.cs](./CS/Scaffolding.CustomFilter/Views/IssueCollectionView.xaml.cs) (VB: [IssueCollectionView.xaml.vb](./VB/Scaffolding.CustomFilter/Views/IssueCollectionView.xaml.vb))
* [IssueView.xaml](./CS/Scaffolding.CustomFilter/Views/IssueView.xaml) (VB: [IssueView.xaml](./VB/Scaffolding.CustomFilter/Views/IssueView.xaml))
* [IssueView.xaml.cs](./CS/Scaffolding.CustomFilter/Views/IssueView.xaml.cs) (VB: [IssueView.xaml.vb](./VB/Scaffolding.CustomFilter/Views/IssueView.xaml.vb))
<!-- default file list end -->
# Scaffolding Wizards - How to create a custom filter


<p>This example demonstrates how to create a custom filter. For more information, refer to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument17152">corresponding</a> help topic.<br /><br />You can encounter the following exception:</p>
<p><em>A first chance exception of type 'System.Data.SqlClient.SqlException' occurred in System.Data.dll</em></p>
<p><em>Additional information: A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 52 - Unable to locate a Local Database Runtime installation. Verify that SQL Server Express is properly installed and that the Local Database Runtime feature is enabled.)</em></p>
<p>This error is caused because the EntityFramework uses the missing LocalDB component.</p>
<p>To fix the issue, locate the <strong>App.config</strong> file within your application and open it. Change the defaultConnectionFactory in the following manner:<br /><br /></p>


```xaml
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" /> 

```



<br/>


