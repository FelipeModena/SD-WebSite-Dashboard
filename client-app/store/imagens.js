export const actions = {
    async postImagem({ }, imgs) {
        let imgDb = new FormData();
        imgs.forEach(img => {
            imgDb.append('files', img);
        });
        await this.$axios.post('api/Imagem/PostListImagens', imgDb, {
            headers: {
                "Content-Type": "multipart/form-data",
            }
        })
            .then(response => {
            })
            .catch(error => {
                console.log(error);
            })
    },
    async deleteImagens({ }, imgs) {
        imgs = imgs.filter(function (img) {
            return img !== undefined
        })
        if (imgs.length != 0) {
            await this.$axios.post('api/Imagem/DeleteListImagensId', imgs)
                .then(response => {
                    console.log("Deletado " + response.data + "com sucesso");
                })
                .catch(error => {
                    console.log(error);
                })
        }
    }

}