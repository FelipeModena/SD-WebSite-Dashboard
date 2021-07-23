export const actions = {
    async postImagem({ }, imgs) {
        let imgDb = new FormData();
        imgs.forEach(img => {
            imgDb.append('files', img);
        });
        await this.$axios.post('Imagem/PostListImagens', imgDb, {
            headers: {
                "Content-Type": "multipart/form-data",
            }
        })
            .then(response => {
                //console.log(response);
            })
            .catch(error => {
                console.log(error);
            })
    }
}