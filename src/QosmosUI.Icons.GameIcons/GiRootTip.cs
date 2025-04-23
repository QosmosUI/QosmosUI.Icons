// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiRootTip : ComponentBase
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
		builder.AddAttribute(14, "d", "M16.508 18.453l-.002 149.908 61.26 49.667 59.757 124.543-9.488-110.738C88.835 182.608 56.58 126.518 67.12 58.338l18.47 2.855c-7.312 47.297 8.4 88.472 33.44 126.67l77.745 43.094 83.868 183.8c70.454 33.943 140.91 58.63 211.365 72.423-47.672-21.634-93.83-50.913-131.332-90.717l-62.45-11.06 3.256-18.4 13.06 3.25 117.42 18.155c-52.808-19.54-101.05-43.642-132.01-85.03-10.244-24.453-17.846-51.365-22.16-81.007-23.356-4.888-46.4-13.233-68.97-25.49l8.92-16.423c26.233 14.248 52.854 22.748 80 26.426l46.75 2.033 146.23 150.81c-18.12-52.077-51.543-121.06-88.19-177.67-30.968-13.506-61.174-15.44-91.886-5.587l-5.71-17.798c14.194-4.553 28.47-6.83 42.746-6.926 2.04-.014 4.078.017 6.117.092 26.897.987 53.746 9.68 79.973 25.42 16.215 8.164 32.85 17.73 50.288 28.525-33.99-44.3-65.738-83.98-117.208-99.594l-.004-.007-23.94 15.336c-36.26 17.486-88.188 18.165-135.264-8.645-21.56 7.324-42.96 12.01-64.166 13.527l-1.334-18.64c26.348-1.886 53.598-9.242 81.577-21.08-18.115-6.645-36.81-15.81-54.095-26.082-22.913-13.617-43.004-28.54-55.545-42.147zM141.354 370.49l-1.4 71.356c38.483 37.214 86.748 46.007 139.91 54.564-64.332-36.743-109.837-71.915-138.51-125.92z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
