public class clsBeTiposEntidades : ICloneable {

	private int mIdTipoEntidad = 0;
	private string mDescripcion = '';
	private int mIdGrupoEntidad = 0;
	private string mComentario = '';
	private string mStatuss = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdTipoEntidad {
		get {
			return mIdTipoEntidad;
		}
		set {
			mIdTipoEntidad = value;
		}
	}

	public String Descripcion {
		get {
			return mDescripcion;
		}
		set {
			mDescripcion = value;
		}
	}

	public Integer IdGrupoEntidad {
		get {
			return mIdGrupoEntidad;
		}
		set {
			mIdGrupoEntidad = value;
		}
	}

	public String Comentario {
		get {
			return mComentario;
		}
		set {
			mComentario = value;
		}
	}

	public String Statuss {
		get {
			return mStatuss;
		}
		set {
			mStatuss = value;
		}
	}

	public Boolean NoEliminable {
		get {
			return mNoEliminable;
		}
		set {
			mNoEliminable = value;
		}
	}

	public String FechaRegistro {
		get {
			return mFechaRegistro;
		}
		set {
			mFechaRegistro = value;
		}
	}

	TiposEntidades(){
	}

	TiposEntidades(){ref int IdTipoEntidad, string Descripcion, int IdGrupoEntidad, string Comentario, string Statuss, bool NoEliminable, String FechaRegistro)
		mIdTipoEntidad = IdTipoEntidad;
		mDescripcion = Descripcion;
		mIdGrupoEntidad = IdGrupoEntidad;
		mComentario = Comentario;
		mStatuss = Statuss;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
