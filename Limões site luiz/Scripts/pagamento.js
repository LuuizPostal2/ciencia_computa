function mostrarFormulario(tipo) {
    document.getElementById('form-debito').style.display = 'none';
    document.getElementById('form-pix').style.display = 'none';
  
    if (tipo === 'debito') {
        document.getElementById('form-debito').style.display = 'block';
    } else if (tipo === 'pix') {
        document.getElementById('form-pix').style.display = 'block';
        gerarCodigoPix(); // Gera o código PIX e QR Code automaticamente
    }
  }
  
  function gerarCodigoPix() {
    const chavePix = "CHAVEPIXEXEMPLO123"; // Chave PIX simulada
    const codigoPix = `00020126360014BR.GOV.BCB.PIX0114${chavePix}520400005303986540410005802BR5925000000000000000`;
  
    const codigoPixCurto = chavePix; // Apresentação mais curta
  
    document.getElementById('codigoPix').innerText = codigoPixCurto;
  
    const qr = new QRious({
        element: document.getElementById('qrCode'),
        value: codigoPix,
        size: 150, // Tamanho do QR code ajustado para ser menor
    });
  
    // Exibe um alerta estilizado informando que o código PIX foi gerado
    Swal.fire({
        title: 'Sucesso!',
        text: 'Código PIX gerado com sucesso!',
        icon: 'success',
        confirmButtonText: 'OK'
    });
  }
  
  function copiarCodigoPix() {
    const codigoPix = document.getElementById('codigoPix').innerText;
    navigator.clipboard.writeText(codigoPix).then(() => {
        Swal.fire({
            title: 'Copiado!',
            text: 'Código PIX copiado!',
            icon: 'success',
            confirmButtonText: 'OK'
        });
    }, (err) => {
        console.error('Erro ao copiar o código PIX: ', err);
        Swal.fire({
            title: 'Erro!',
            text: 'Erro ao copiar o código PIX',
            icon: 'error',
            confirmButtonText: 'OK'
        });
    });
  }
  