const InclusaoClientes=()=>{
   return(       
         <div className="container">
             <h4 className="fst-italic mt-3">Inclusão</h4>
             <form>
                <div className="form-group">
                    <input type="text" className="form-control" id="nome"
                    required autoFocus/>
                </div>
                <div className="form-group">
                    <input type="tel" className="form-control" id="telefone"
                    required autoFocus/>
                </div>
                <div className="form-group">
                    <input type="email" className="form-control" id="email"
                    required autoFocus/>
                </div>
                <div className="form-group">
                    <input type="date" className="form-control" id="dataNascimento"
                    required autoFocus/>
                </div>
                <input type="submit" className="btn btn-primary mt-3" value="Enviar"/>
                <input type="reset" className="btn btn-danger mt-3 ms-3" value="Limpar"/>
             </form>
             <div className="alert"></div>
         </div>
   );
};
export default InclusaoClientes;
