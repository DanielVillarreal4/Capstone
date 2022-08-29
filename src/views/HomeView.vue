<template>
  <!-- <hello-world /> -->
  <div>
    <v-row class="pa-6" align="center" justify="center">
      <v-carousel
        class="carouselClass pd-6"
        hide-delimiters
        show-arrows-on-hover
        cycle
        :interval="5000"
        height="300px"
      >
        <v-carousel-item
          v-for="(item, i) in items"
          :key="i"
          :src="item.src"
        ></v-carousel-item>
      </v-carousel>
    </v-row>
  </div>
</template>

<script>
// import HelloWorld from '../components/HelloWorld'

export default {
  name: "HomeView",
  data() {
    return {
      items: [
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/sky.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/bird.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/planet.jpg",
        },
      ],
    };
  },
};
</script>

<style scoped>
.carouselClass {
  max-width: 50%;
  align-content: center !important;
  justify-content: center !important;
}
</style>