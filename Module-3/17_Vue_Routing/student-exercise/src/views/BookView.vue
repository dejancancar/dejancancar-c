<template>
  <div>
    <book-details :isbn="isbn" />
  </div>
</template>

<script>

import BookDetails from "../components/BookDetails.vue";
export default {
      name: 'book',
  components: {
    BookDetails
  },

  data() {
    return {
      isbn: 0,
    };
  },
  created() {
    this.isbn = parseInt(this.$route.params.isbn);
  },
};
</script>

<style>
</style>