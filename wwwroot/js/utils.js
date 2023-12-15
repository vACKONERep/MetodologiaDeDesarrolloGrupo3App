function DescargarExcel(nombreArchivo,base64Archivo) {
    const link = document.createElement("a");
    link.download = nombreArchivo;
    //link.href = "data:application/octet-stream;base64," + base64Archivo;
    link.href = "data:application/vnd.ms-excel;base64," + base64Archivo;
    //link.href = "data:application/vnd.openxmlformats-officedocumen.spreadsheetml.sheet;base64," + base64Archivo;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}