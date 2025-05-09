// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSleepy : ComponentBase
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
		builder.AddAttribute(14, "d", "M249.094 18.25c-42.675 0-81.852 25.486-110.938 68.438C109.07 129.637 90.72 189.74 90.72 256.28c0 66.543 18.35 126.643 47.436 169.595s68.263 68.47 110.938 68.47 81.883-25.518 110.97-68.47c29.084-42.952 47.436-103.052 47.436-169.594 0-66.54-18.352-126.64-47.438-169.592C330.978 43.736 291.77 18.25 249.094 18.25zm-128.97 241.313c18.356 18.096 37.528 26.765 55.72 27.562 18.19.797 35.927-6.096 52.125-21.5l12.874 13.53c-19.214 18.274-42.25 27.658-65.813 26.626-23.56-1.03-47.1-12.3-68-32.905l13.095-13.313zm264.782 0l13.125 13.312C377.135 293.48 353.564 304.75 330 305.78c-23.563 1.033-46.598-8.35-65.813-26.624l12.875-13.53c16.2 15.403 33.934 22.296 52.125 21.5 18.192-.798 37.365-9.467 55.72-27.563zM251.562 371.656c36.423-.156 72.996 19.144 77.438 58.406-51.33 13.296-102.67 12.767-154 0 3.858-38.638 40.14-58.25 76.563-58.406z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
