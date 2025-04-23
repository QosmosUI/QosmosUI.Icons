// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBullHorns : ComponentBase
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
		builder.AddAttribute(14, "d", "M73.813 39.28c70.517 36.34 49.052 103.816 8.374 138.22-88.595 74.925-82.78 199.22 48.25 244.563-10.524-32.924-9.554-66.272 2.063-99.063-30.195-25.72-38.378-63.247 11.906-135.656 30.388-43.758 23.922-140.87-70.594-148.063zm361.5 0c-94.516 7.193-100.982 104.306-70.594 148.064 47.774 68.795 42.742 106.107 16.217 131.72 7.033 17.736 12.06 35.84 13.282 54.467.963 14.702-.57 29.68-5.25 44.72 120.973-48.166 124.15-167.84 37.936-240.75-40.677-34.404-62.11-101.88 8.406-138.22zm-79.875 268.345c-66.123 9.62-131.398 17.49-196.22.688-23.464 45.56-24.194 89.256.47 134.656 65.572-6.135 131.11-5.805 196.593.06 15.795-23.503 20.762-45.73 19.283-68.28-1.44-21.957-9.355-44.356-20.125-67.125z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
