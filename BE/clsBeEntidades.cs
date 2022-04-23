public class clsBeEntidades : ICloneable {

	private int mIdEntidad = 0;
	private string mDescripcion = '';
	private string mDireccion = '';
	private string mLocalidad = '';
	private string mTipoEntidad = '';
	private string mTipoDocumento = '';
	private int mNumeroDocumento = 0;
	private string mTeléfonos = '';
	private string mURLPaginaWeb = '';
	private string mURLFacebook = '';
	private string mURLInstagram = '';
	private string mURLTwitter = '';
	private string mURLTikTok = '';
	private int mIdGrupoEntidad = 0;
	private int mIdTipoEntidad = 0;
	private int mLimiteCredito = 0;
	private string mUserNameEntidad = '';
	private string mPassworEntidad = '';
	private string mRolUserEntidad = '';
	private string mComentario = '';
	private string mStatuss = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdEntidad {
		get {
			return mIdEntidad;
		}
		set {
			mIdEntidad = value;
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

	public String Direccion {
		get {
			return mDireccion;
		}
		set {
			mDireccion = value;
		}
	}

	public String Localidad {
		get {
			return mLocalidad;
		}
		set {
			mLocalidad = value;
		}
	}

	public String TipoEntidad {
		get {
			return mTipoEntidad;
		}
		set {
			mTipoEntidad = value;
		}
	}

	public String TipoDocumento {
		get {
			return mTipoDocumento;
		}
		set {
			mTipoDocumento = value;
		}
	}

	public Integer NumeroDocumento {
		get {
			return mNumeroDocumento;
		}
		set {
			mNumeroDocumento = value;
		}
	}

	public String Teléfonos {
		get {
			return mTeléfonos;
		}
		set {
			mTeléfonos = value;
		}
	}

	public String URLPaginaWeb {
		get {
			return mURLPaginaWeb;
		}
		set {
			mURLPaginaWeb = value;
		}
	}

	public String URLFacebook {
		get {
			return mURLFacebook;
		}
		set {
			mURLFacebook = value;
		}
	}

	public String URLInstagram {
		get {
			return mURLInstagram;
		}
		set {
			mURLInstagram = value;
		}
	}

	public String URLTwitter {
		get {
			return mURLTwitter;
		}
		set {
			mURLTwitter = value;
		}
	}

	public String URLTikTok {
		get {
			return mURLTikTok;
		}
		set {
			mURLTikTok = value;
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

	public Integer IdTipoEntidad {
		get {
			return mIdTipoEntidad;
		}
		set {
			mIdTipoEntidad = value;
		}
	}

	public Integer LimiteCredito {
		get {
			return mLimiteCredito;
		}
		set {
			mLimiteCredito = value;
		}
	}

	public String UserNameEntidad {
		get {
			return mUserNameEntidad;
		}
		set {
			mUserNameEntidad = value;
		}
	}

	public String PassworEntidad {
		get {
			return mPassworEntidad;
		}
		set {
			mPassworEntidad = value;
		}
	}

	public String RolUserEntidad {
		get {
			return mRolUserEntidad;
		}
		set {
			mRolUserEntidad = value;
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

	Entidades(){
	}

	Entidades(){ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, int NumeroDocumento, string Teléfonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, int IdGrupoEntidad, int IdTipoEntidad, int LimiteCredito, string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Statuss, bool NoEliminable, String FechaRegistro)
		mIdEntidad = IdEntidad;
		mDescripcion = Descripcion;
		mDireccion = Direccion;
		mLocalidad = Localidad;
		mTipoEntidad = TipoEntidad;
		mTipoDocumento = TipoDocumento;
		mNumeroDocumento = NumeroDocumento;
		mTeléfonos = Teléfonos;
		mURLPaginaWeb = URLPaginaWeb;
		mURLFacebook = URLFacebook;
		mURLInstagram = URLInstagram;
		mURLTwitter = URLTwitter;
		mURLTikTok = URLTikTok;
		mIdGrupoEntidad = IdGrupoEntidad;
		mIdTipoEntidad = IdTipoEntidad;
		mLimiteCredito = LimiteCredito;
		mUserNameEntidad = UserNameEntidad;
		mPassworEntidad = PassworEntidad;
		mRolUserEntidad = RolUserEntidad;
		mComentario = Comentario;
		mStatuss = Statuss;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
