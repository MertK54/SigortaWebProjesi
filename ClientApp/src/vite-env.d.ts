/// <reference types="vite/client" />

interface ImportMetaEnv {
    VITE_BASE_URL: string; // burada kullanacağınız başka değişkenler varsa tanımlayın
  }
  
  interface ImportMeta {
    readonly env: ImportMetaEnv;
  }
  