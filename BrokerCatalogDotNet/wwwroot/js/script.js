
async function carregarLista() {
    const resposta = await fetch("/corretoras");
    const dados = await resposta.json();  // Converte texto em array de objetos Javascript

    const ul = document.getElementById("Brokerlist");
    ul.innerHTML = "";

    // Cabeçalho da tabela
    const header = document.createElement("li");
    header.className = "item cabecalho";
        header.innerHTML = `
        <span> Nome Social</span>
        <span> Município</span>
        <span> CNPJ</span>
        `;
    ul.appendChild(header);
        
    // Lista de corretoras
    dados.forEach(item => {
        const li = document.createElement("li");
        li.className = "item";

        li.innerHTML = `
                        <span>${item.nome_social}</span>
                        <span>${item.municipio}</span>
                        <span>${item.cnpj}</span>
                `;
        ul.appendChild(li);
    });

}