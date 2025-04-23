// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaHatWizardSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 28 C 9.796875 28 7.535156 25.945313 7.296875 25.710938 L 6.824219 25.246094 L 15.324219 4 L 22.941406 4 L 18.214844 7.363281 L 25.171875 25.25 L 24.703125 25.710938 C 24.464844 25.945313 22.203125 28 16 28 Z M 9.222656 24.636719 C 10.101563 25.136719 12.175781 26 16 26 C 19.828125 26 21.898438 25.136719 22.78125 24.632813 L 16.101563 7.445313 Z M 18 24 C 16.34375 24 15 22.65625 15 21 C 15 19.34375 16.34375 18 18 18 C 18.261719 18 18.507813 18.042969 18.75 18.105469 C 18.03125 17.425781 17.066406 17 16 17 C 13.789063 17 12 18.789063 12 21 C 12 23.210938 13.789063 25 16 25 C 17.066406 25 18.03125 24.574219 18.75 23.894531 C 18.507813 23.957031 18.261719 24 18 24 Z M 16 13 C 16.550781 13 17 13.449219 17 14 C 17 14.550781 16.550781 15 16 15 C 15.449219 15 15 14.550781 15 14 C 15 13.449219 15.449219 13 16 13 Z M 19 20 C 19.550781 20 20 20.449219 20 21 C 20 21.550781 19.550781 22 19 22 C 18.449219 22 18 21.550781 18 21 C 18 20.449219 18.449219 20 19 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
