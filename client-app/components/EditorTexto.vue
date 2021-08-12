<template>
  <div 
    class="quill-editor" 
    :content="value"
    @change="onEditorChange($event)"
    v-quill:myQuillEditor="editorOption"
  >
  </div>
</template>

<script>
  export default {
    props: {
      value: { type: String, default: '' }
    },
    data() {
      return {
        editorOption: {
          // some quill options
          modules: {
            toolbar: [
              [{ 'size': ['small', 'large', 'huge'] }, { 'font': [] }],
              ['bold', 'italic', 'underline', 'strike'],
              [{ 'color': [] }, { 'background': [] }],
              [{ 'align': [] }],
              ['image', 'link']
            ]
          }
        }
      }
    },
    methods: {
      onEditorChange({ editor, html, text }) {
        this.$emit("update:value", html)
      },
    },
  }
</script>

<style scoped>

  .quill-editor {
    width: 97%;
    min-height: 200px;
    max-height: 240px;
    overflow-y: auto;
  }
</style>
