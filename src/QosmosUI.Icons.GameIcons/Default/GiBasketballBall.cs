// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBasketballBall : ComponentBase
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
		builder.AddAttribute(14, "d", "M248.37 41.094c-49.643 1.754-98.788 20.64-137.89 56.656L210.53 197.8c31.283-35.635 45.59-88.686 37.84-156.706zm18.126.107c7.646 71.205-7.793 129.56-43.223 169.345L256 243.27 401.52 97.75c-38.35-35.324-86.358-54.18-135.024-56.55zM97.75 110.48c-36.017 39.102-54.902 88.247-56.656 137.89 68.02 7.75 121.07-6.557 156.707-37.84L97.75 110.48zm316.5 0L268.73 256l32.71 32.71c33.815-30.112 81.05-45.78 138.183-45.11 10.088.118 20.49.753 31.176 1.9-2.37-48.665-21.227-96.672-56.55-135.02zM210.545 223.272c-39.785 35.43-98.14 50.87-169.344 43.223 2.37 48.666 21.226 96.675 56.55 135.025L243.27 256l-32.725-32.727zm225.002 38.27c-51.25.042-92.143 14.29-121.348 39.928l100.05 100.05c36.017-39.102 54.902-88.247 56.656-137.89-12.275-1.4-24.074-2.096-35.36-2.087zM256 268.73L110.48 414.25c38.35 35.324 86.358 54.18 135.024 56.55-7.646-71.205 7.793-129.56 43.223-169.345L256 268.73zm45.47 45.47c-31.283 35.635-45.59 88.686-37.84 156.706 49.643-1.754 98.788-20.64 137.89-56.656L301.47 314.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
