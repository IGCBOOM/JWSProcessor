using JWSLib;

foreach (var arg in args)
{

    var file = new JWSFile(arg, 1);
    file.ExportToCSV();

}
