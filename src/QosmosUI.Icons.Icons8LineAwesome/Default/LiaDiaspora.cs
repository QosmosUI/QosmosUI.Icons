// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDiaspora : ComponentBase
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
		builder.AddAttribute(14, "d", "M 12.005859 5 L 12.005859 11.142578 L 6.3691406 9.2636719 L 4.1542969 15.904297 L 9.8164062 17.792969 L 6.0996094 22.800781 L 11.720703 26.972656 L 15.390625 22.027344 L 18.861328 27.099609 L 24.636719 23.146484 L 21.039062 17.890625 L 26.816406 16.023438 L 24.664062 9.3613281 L 20 11.191406 L 19 5 L 12.005859 5 z M 14 7 L 17.005859 7 L 17.005859 13.939453 L 23.376953 11.880859 L 24.298828 14.734375 L 17.876953 16.810547 L 21.857422 22.625 L 19.380859 24.318359 L 15.455078 18.582031 L 11.306641 24.175781 L 8.8964844 22.386719 L 13.066406 16.767578 L 6.6855469 14.640625 L 7.6328125 11.794922 L 14 14 L 14 7 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
