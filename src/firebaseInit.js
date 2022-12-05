import firebase from 'firebase/compat/app';
import 'firebase/compat/firestore';

var firebaseConfig = {
    apiKey: "Your API Key",
    authDomain: "Your Auth Domain",
    projectId: "Your Project ID",
    storageBucket: "Your Storage Bucket",
    messagingSenderId: "Your Messaging Sender ID",
    appId: "Your AppID",
    measurementId: "Your Measurement ID"
  };

  export default firebase.initializeApp(firebaseConfig);