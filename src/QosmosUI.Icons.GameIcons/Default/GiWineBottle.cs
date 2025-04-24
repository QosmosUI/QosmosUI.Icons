// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWineBottle : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M133.99 28v23.512h52.02V28h-52.02zm0 41.51v90.705c-26.01 17.34-43.347 39.014-43.347 56.353v260.735S90.64 494 107.98 494h103.967c17.411 0 17.41-17.34 17.41-17.34V216.568c0-17.34-17.338-39.014-43.347-56.353V69.51h-52.02zM107 252h106v162H107V252zm194.514 3l-2.051 6.154c-8.474 25.423-12.793 58.44-6.233 86.87 3.28 14.215 9.429 27.45 19.846 37.273 8.61 8.118 20.105 13.533 33.924 15.172v74.64C327.601 479.296 302 494 302 494h108s-25.601-14.705-45-18.89v-74.641c13.82-1.639 25.314-7.054 33.924-15.172 10.417-9.822 16.565-23.058 19.846-37.274 6.56-28.43 2.241-61.446-6.233-86.869l-2.05-6.154H301.513zM125 270v126h70V270h-70zm189.703 3h82.594c2.639 9.261 4.629 19.565 5.68 30h-93.954c1.051-10.435 3.041-20.739 5.68-30zm-6.486 48h95.566c-.116 8.04-.907 15.846-2.553 22.977-2.72 11.784-7.571 21.548-14.654 28.226C379.494 378.881 370.126 383 356 383c-14.125 0-23.494-4.12-30.576-10.797-7.083-6.678-11.935-16.442-14.654-28.226-1.646-7.131-2.437-14.938-2.553-22.977z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
