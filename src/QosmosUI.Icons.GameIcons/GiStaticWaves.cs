// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStaticWaves : ComponentBase
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
		builder.AddAttribute(14, "d", "M271.688 18.076c30.998 22.56 59.474 47.18 85.85 74.17-55.465-17.182-111.375-24.518-166.444-24.53 131.154 56.898 232.282 146.106 301.353 302.522v-65.394c-43.575-82.686-107.69-155.17-176.906-190.42C388.585 135.42 446.776 179.83 490 223.034 441.175 96.127 375.416 38.693 271.688 18.075zM66.692 20.994C52.09 133.23 55.57 248.46 88.887 360.31c-33.756-40.1-58.85-84.33-71.25-130.236 1.203 129.388 75.925 229.466 194.035 261.7-54.595-68.506-108.85-165.455-111.063-290.587 28.372 118.453 129.845 227.278 256.544 294.03H480.18C248.53 386.68 129.253 227.084 66.693 20.994zm19.805 15.313l156.135 180.22c-32.287-17.453-65.367-34.38-98.07-51.318 85.847 129.425 186.64 243.742 347.11 295.397-64.525-60.37-95.74-102.014-127.757-150.318-48.695-14.554-101.03-37.668-144.51-76.456 44.58 26.788 123.108 42.688 185.977 48.342-79.726-127.645-192.9-186.57-318.885-245.87z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
