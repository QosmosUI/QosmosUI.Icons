// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLizardTongue : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.438 22.813l2.656 324.406c18.762-2.59 45.968-7.837 64.937-12.626-64.105-101.55-51.24-197.13 2.345-249.656 53.66-52.602 146.458-59.904 233.188 7.343 4.837-9.855 10.408-22.83 16.78-36 5.467-11.292 11.663-22.63 18.907-32.75l-338.813-.718zM193.155 61.75c-2.916-.003-5.797.078-8.656.25l93.125 55.25 13.47-23.938c-33.99-21.88-67.484-31.535-97.94-31.562zm-48.125 8.688c-16.48 6.286-31.224 15.78-43.56 27.874-19.777 19.386-33.67 45.742-38.5 77 45.306 7.664 79.056 38.977 82.5 80.97 4.68 57.115 70.693 102.11 120.624 96.593 66.34-7.337 91.348 25.706 101.937 75.938 11.52 54.665 62.34 79.21 126.5 65.5-50.166-15.56-93.128-41.772-92.655-102.844.473-61.074-34.86-95.83-82.28-98.783-59.558-3.705-78.226-42.47-81.25-94.5-2.15-36.966-41.773-95.566-93.314-127.75zm-83.936 130c.064 32.407 9.32 68.854 30.656 107.5l22.313-13.25-52.97-94.25z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
