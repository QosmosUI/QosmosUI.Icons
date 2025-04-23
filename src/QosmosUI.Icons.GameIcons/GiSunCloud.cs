// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSunCloud : ComponentBase
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
		builder.AddAttribute(14, "d", "M383.215 71.94a96 96 0 0 0-96 96 96 96 0 0 0 8.484 39.17c2.492-.108 4.994-.166 7.503-.17h.011c34.226.002 65.356 9.18 88.478 24.636 10.776 7.204 19.885 15.916 26.54 25.738a96 96 0 0 0 60.982-89.373 96 96 0 0 0-96-96zM154.662 179.845c-47.352.003-85.174 36.46-85.178 81.19v.007c.005 7.39 1.07 14.74 3.162 21.86l2.788 9.477-9.698 1.894c-13.05 2.55-23.76 7.818-30.85 14.125-7.087 6.303-10.49 13.255-10.5 20.293v.003c.002 8.806 5.325 17.41 15.807 24.398 10.482 6.988 25.778 11.695 42.832 11.697 8.47-.017 16.842-1.206 24.483-3.443l4.605-1.35 3.686 3.072c17.088 14.243 49.872 24.26 85.2 24.27 14.3-.024 28.434-1.62 41.37-4.64l7.33-1.714 2.982 6.91c8.13 18.84 35.242 34.145 67.123 34.17 20.066-.003 38.075-5.86 50.593-14.742 12.492-8.862 19.286-20.168 19.317-32.172-.012-.335-.028-.67-.05-1.007l-.7-10.11 10.12.495c3.337.164 6.696.252 10.06.26 23.21-.002 44.206-3.737 58.597-9.3 7.198-2.783 12.702-6.056 15.924-9 3.216-2.94 3.942-4.99 3.945-6.514-.004-1.374-.584-3.16-3.215-5.794-2.637-2.64-7.215-5.67-13.352-8.352-12.275-5.363-30.592-9.408-51.623-10.412l-10.803-.516 2.47-10.53c.747-3.18 1.134-6.365 1.18-9.555-.023-18.135-10.99-35.177-30.578-48.27-19.606-13.107-47.5-21.598-78.475-21.6-20.483.028-40.557 3.834-57.793 10.85l-8.252 3.36-3.443-8.216c-12.866-30.71-44.097-51.07-79.06-51.09h-.005z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
