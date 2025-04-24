// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBowArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M331.734 20.443a4.421 4.421 0 0 0-1.802.327c-27.736 11.543-47.295 57.495-29.899 76.671 33.52 38.946 72.835 55.573 90.147 128.434 2.607 20.15 1.218 40.094 0 60.25-17.312 72.861-56.627 89.488-90.147 128.434-17.396 19.176 2.163 65.128 29.899 76.671 9.038 3.762 28.025-26.165 21.752-25.209-16.34 2.491-37.8-20.941-28.387-28.93 38.47-32.65 105.49-100.055 100.277-135.552-2.211-15.057-9.35-30.36-15.574-45.539 6.225-15.18 13.363-30.482 15.574-45.54 5.214-35.496-61.806-102.901-100.277-135.552-9.412-7.988 12.047-31.42 28.387-28.93 5.881.897-10.44-25.35-19.95-25.535zM152 24.23l-21.441 53.602L152 99.273l21.441-21.441zm-9 91.497v296.546l9-9 9 9V115.727l-2.637 2.636-6.363 6.364zm160 9.847v260.824l18-17.53V143.104zM152 428.727l-23 23v38.546l23-23 23 23v-38.546z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
