//crie uma referência ao form e ao elemento h3
//DOM
const frm = document.querySelector("form")
const resp = document.querySelector("h3")

//cria um "ouvinte" de evento, 
//acionado quando o botão submit for clicado
const dataNasc = document.querySelector("form").inData.value
frm.addEventListener("submit",(e)=>{
    const nome = frm.inNome.value
    const telefone = frm.inTelefone.value
    const email = frm.inEmail.value
    resp.innerText = `Olá ${nome} 
             seu telefone é:${telefone} 
             e o email:${email}
             Sua data de nascimento é: ${dataNasc}`
    e.preventDefault()//evitar o envio do form.
})

