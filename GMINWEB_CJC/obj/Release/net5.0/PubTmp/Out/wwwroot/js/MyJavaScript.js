﻿function DownloadAsFile(fileName,fileType, bytesBase64) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = 'data:' + fileType + ';base64,' + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.removeChild(link);
}

function Print() {
    window.print();
}