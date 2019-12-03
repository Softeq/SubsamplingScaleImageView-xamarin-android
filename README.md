# Subsampling Scale Image View

Xamarin binding library for [SubsamplingScaleImageView](https://github.com/davemorrissey/subsampling-scale-image-view) Android library.

---

A custom image view for Android, designed for photo galleries and displaying huge images (e.g. maps and building plans) without OutOfMemoryErrors. Includes pinch to zoom, panning, rotation and animation support, and allows easy extension so you can add your own overlays and touch event detection.

The view optionally uses subsampling and tiles to support very large images - a low resolution base layer is loaded and as you zoom in, it is overlaid with smaller high resolution tiles for the visible area. This avoids holding too much data in memory. It's ideal for displaying large images while allowing you to zoom in to the high resolution details. You can disable tiling for smaller images and when displaying a bitmap object. There are some advantages and disadvantages to disabling tiling so to decide which is best, see [the original wiki](https://github.com/davemorrissey/subsampling-scale-image-view/wiki/02.-Displaying-images).


## About

This project is maintained by Softeq Development Corp.

We specialize in developing mobile applications using Xamarin and native technology stack.

## Installation

NuGet:

```
Install-Package SubsamplingScaleImageViewBinding
```

The minimum SDK is now 14.

## License

SubsamplingScaleImageViewBinding library for android is released under the MIT license. See [LICENSE](LICENSE) for details.

The original SubsamplingScaleImageView project was created by Dave Morrissey under a different [license](https://github.com/davemorrissey/subsampling-scale-image-view/blob/master/LICENSE) (Apache License 2.0)
