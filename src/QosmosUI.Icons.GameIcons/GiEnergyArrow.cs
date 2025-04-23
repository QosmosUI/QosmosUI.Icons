// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiEnergyArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M84.066 17.832l9.3 55.445-43.282-40.412h-.002L36.064 46.88l38.424 41.155-52.37-8.252 52.695 76.11 58.958-4.364 166.484 178.314-48.95-9.89 77.725 61.44-117.69-14.316 84.664 35.246-42.86 16.95 64.217 19.97-33.862 25.36 182.43 20.84 28.435 8.845-5.28-16.98-4.808-15.464-20.51-182.217-25.894 32.993-18.518-59.56-17.04 43.1-35.177-93.468-1.87 110.494-63.757-91.374 10.5 55.594-155.776-145.44 4.596-62.093-76.762-52.045zM268.27 71.254l142.714 156.144 30.81 14.963-10.304-62.438L268.27 71.254zm-62.377 12.81l92.97 115.235 36.477-.935-14.836-35.195-114.61-79.106zM42.018 212.884L160.42 419.7l55.393 19.765-8.333-36.324L42.018 212.884zm92.117 23.08l46.824 83.112 47.577 18.723-17.23-41.66-77.172-60.175zm283.107 73.255l48.72 156.665-156.665-48.72 77.36-30.59 30.585-77.356z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
