
function addProduct(productName) {
    const list = document.getElementById('selectedProductsList');
    
    // Cria o item de lista para o produto
    const listItem = document.createElement('li');
    listItem.className = 'list-group-item d-flex align-items-center justify-content-between';
    
    // Div para informações do produto
    const productDetails = document.createElement('div');
    productDetails.className = 'd-flex flex-column';

    // Nome do produto
    const productNameElement = document.createElement('span');
    productNameElement.textContent = productName;
    productNameElement.className = 'fw-bold'; // Estilo em negrito para o nome

    // Campo de quantidade
    const quantityInput = document.createElement('input');
    quantityInput.type = 'number';
    quantityInput.className = 'form-control form-control-sm';
    quantityInput.style.width = '60px';
    quantityInput.value = 1; // Quantidade inicial
    quantityInput.min = 1;

    // Anexa os elementos ao item de lista
    productDetails.appendChild(productNameElement);
    productDetails.appendChild(quantityInput);
    listItem.appendChild(productDetails);

    // Botão para remover o item da lista
    const removeButton = document.createElement('button');
    removeButton.className = 'btn btn-danger btn-sm';
    removeButton.textContent = 'Remover';
    removeButton.onclick = () => listItem.remove();

    // Adiciona o botão de remover ao item de lista
    listItem.appendChild(removeButton);

    // Adiciona o item à lista de produtos selecionados
    list.appendChild(listItem);
}
