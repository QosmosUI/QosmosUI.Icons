// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBayonet : ComponentBase
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
		builder.AddAttribute(14, "d", "M238.219 131.963l-.24.19-6.41-8a14.89 14.89 0 0 1 2.27-20.94l1.51-1.21a14.89 14.89 0 0 1 20.94 2.3l6.41 8zm-7.18 40.88l18.76 23.32 11.85-9.53-18.76-23.33zm72.91 40.85l176.34-141.83v-44.56h-86.42l-145.58 117.13zm142.81-4c-2 1.64-3.7 2.31-5.16 2.31-4.79 0-7.29-7.26-13.09-11.09a10.74 10.74 0 0 0-6-1.74c-3.71 0-7.59 1.59-10.91 3.69-3.32 2.1-28.75 33.49-41.36 43.63-11.87 9.55-38.27 21.46-53.46 36.38l-27.16-33.76 113.22-91.06a22.73 22.73 0 0 1 14.19-5 19.46 19.46 0 0 1 16.37 8.29c7.04 10.4 23.13 40.51 13.36 48.37zm-113.62 31.89a7.26 7.26 0 1 0-1.11 10.21 7.26 7.26 0 0 0 1.11-10.21zm82.3-66.19a7.26 7.26 0 1 0-1.15 10.2 7.26 7.26 0 0 0 1.15-10.21zm-164.48 95.37l36.33 45.17-144 115.84c-11.65 9.37-106.88 58.17-111.47 52.46-3-3.67 57.76-83.64 75.14-97.63zm-64.14 80.76c-38.85 31.24-68.65 58.67-66.56 61.27 2.09 2.6 35.27-20.63 74.11-51.87 38.84-31.24 68.65-58.67 66.56-61.27-2.09-2.6-35.26 20.65-74.11 51.87zm40.65-135.5l102 126.77 9.09-7.31-102-126.77zm-16.43 27.36l18.75 23.32 10.87-8.74-18.76-23.32zm77.25-23.69l-18.8-23.32-13.55 10.93 18.76 23.32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
