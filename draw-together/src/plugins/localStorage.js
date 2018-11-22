export default store => {
    store.subscribe((m, state) => {
      // Save the entire state to Local Storage
      console.log(m);
      localStorage.setItem('state', JSON.stringify(state));
    });
  };