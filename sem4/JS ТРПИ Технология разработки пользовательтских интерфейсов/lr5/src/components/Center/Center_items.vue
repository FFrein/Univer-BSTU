<template>
  <div :class="$style['items']" v-for="item in items" v-bind:key="item">
    <h5>{{item.sub_title}}</h5>
    <h1>{{item.title}}</h1>
    <div :class="$style['gallery']">
      <div :class="$style['images']"
           v-for="image in item.images"
           v-bind:key="image"
           @click="handleItemClick(image)"
           @mouseout="handleItemOut(image)"
      >
          <img v-bind="image"

          />
      </div>
    </div>
  </div>
</template>

<script>

import styles from "@/components/Center/CenterComponent.module.css";

export default {
  name: "Center_items",
  data(){
    return{
      ImageViewer: false,
      items:[
        {id:1, sub_title:"LANDING PAGES", title: "Discover all the pages that you can use over\n and over again.", images:[{src: "assets/Center/Frame1.png"}, {src: "assets/Center/Frame1.png"}, {src: "assets/Center/Frame1.png"}]},
        {id:2, sub_title:"COMPANY", title: "Company Pages", images:[{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"}]},
        {id:3, sub_title:"BLOG", title: "CMS Pages", images:[{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"}]},
        {id:4, sub_title:"PRICING", title: "Pricing Pages", images:[{src: "assets/Center/Frame1.png"},{src: "assets/Center/Frame1.png"}]}
      ],

    }
  },
  methods:{
    handleItemClick(image){
      image.class = 'ViewImg'
    },
    handleItemOut(image){
      image.class = 'NoViewImg'
    }
  },
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>

<style scoped>
/*Анимация картинки*/
.ViewImg{
  scale: 120%;
  transition: all 0.5s ease;
}

.NoViewImg{
  scale: 100%;
  transition: all 0.5s ease;
}
</style>