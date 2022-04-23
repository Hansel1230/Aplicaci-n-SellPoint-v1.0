public class clsBeGruposEntidades : ICloneable {

	private int mIdGrupoEntidad = 0;
	private string mDescripcion = '';
	private string mComentario = '';
	private string mStatuss = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdGrupoEntidad {
		get {
			return mIdGrupoEntidad;
		}
		set {
			mIdGrupoEntidad = value;
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

	GruposEntidades(){
	}

	GruposEntidades(){ref int IdGrupoEntidad, string Descripcion, string Comentario, string Statuss, bool NoEliminable, String FechaRegistro)
		mIdGrupoEntidad = IdGrupoEntidad;
		mDescripcion = Descripcion;
		mComentario = Comentario;
		mStatuss = Statuss;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
