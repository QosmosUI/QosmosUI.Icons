// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoPeopleCircle : ComponentBase
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
		builder.AddAttribute(14, "d", "M258.9,48C141.92,46.42,46.42,141.92,48,258.9,49.56,371.09,140.91,462.44,253.1,464c117,1.6,212.48-93.9,210.88-210.88C462.44,140.91,371.09,49.56,258.9,48Zm-3.68,152.11c.21-1.2.44-2.4.71-3.59a66.46,66.46,0,0,1,16.29-31.21C285.11,151.58,303.38,144,323.67,144a74.05,74.05,0,0,1,25.06,4.26A66.69,66.69,0,0,1,375,165.46a68.15,68.15,0,0,1,18,42.14A78.46,78.46,0,0,1,393,219h0a86.19,86.19,0,0,1-8.2,31q-.76,1.59-1.59,3.15c-1.11,2.07-2.3,4.1-3.58,6.06a79.47,79.47,0,0,1-8.63,11c-13.12,14-29.92,21.73-47.31,21.73a59.61,59.61,0,0,1-19.17-3.18,63.47,63.47,0,0,1-6.1-2.43,70.76,70.76,0,0,1-22.07-16.12,83.76,83.76,0,0,1-22-51.32q-.27-3.88-.18-7.68A75.62,75.62,0,0,1,255.22,200.13ZM105.49,224.45a59.87,59.87,0,0,1,5.2-20.64,56.76,56.76,0,0,1,2.78-5.3,54.49,54.49,0,0,1,7.19-9.56,55.62,55.62,0,0,1,14-10.82,56.84,56.84,0,0,1,8.11-3.64,63.85,63.85,0,0,1,33.35-2.39,57,57,0,0,1,30.78,17,57.86,57.86,0,0,1,15.41,38.62c.05,2.11,0,4.23-.15,6.38a71.58,71.58,0,0,1-6,23.84,69.49,69.49,0,0,1-5.73,10.42,65.39,65.39,0,0,1-15.76,16.57C193.17,286,191.61,287,190,288a54.21,54.21,0,0,1-10,4.65,49.31,49.31,0,0,1-16.2,2.76c-.93,0-1.86,0-2.78-.08a47.6,47.6,0,0,1-5.48-.62,51.19,51.19,0,0,1-5.35-1.23,53.54,53.54,0,0,1-7.72-2.89c-.84-.39-1.66-.8-2.48-1.23-18-9.49-31.57-29.16-34.23-52.12-.12-1.05-.22-2.1-.29-3.16A66.59,66.59,0,0,1,105.49,224.45Zm53.92,178.6A177.27,177.27,0,0,1,97.47,332.4a4,4,0,0,1,1.62-5.26C117.67,316.69,141.4,311,163.82,311c17,0,30.7,2,42.69,5.88a8,8,0,0,1,2.59,13.77c-23.35,19-38.4,42.54-45.47,70.75v0A2.77,2.77,0,0,1,159.41,403.05ZM256,432a175.12,175.12,0,0,1-65.7-12.72,4,4,0,0,1-2.4-4.46c.4-2.05.84-3.92,1.23-5.48,7.12-28.43,24.76-52,51-68.18,23.29-14.35,53-22.25,83.52-22.25,31.16,0,60,7.58,83.48,21.91h0a2.72,2.72,0,0,1,.91,3.67A176.1,176.1,0,0,1,256,432Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M161,295.28a47.6,47.6,0,0,1-5.48-.62A47.6,47.6,0,0,0,161,295.28Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M134.64,178.13a55.62,55.62,0,0,0-14,10.82,54.49,54.49,0,0,0-7.19,9.56,54.49,54.49,0,0,1,7.19-9.56A55.62,55.62,0,0,1,134.64,178.13Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M216.17,257.89a71.58,71.58,0,0,0,6-23.84c.15-2.15.2-4.27.15-6.38q.08,3.15-.15,6.38A71.58,71.58,0,0,1,216.17,257.89Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M134.64,178.13a56.84,56.84,0,0,1,8.11-3.64A56.84,56.84,0,0,0,134.64,178.13Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M150.21,293.43a53.54,53.54,0,0,1-7.72-2.89A53.54,53.54,0,0,0,150.21,293.43Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M105.78,237.19c2.66,23,16.26,42.63,34.23,52.12C122,279.82,108.44,260.15,105.78,237.19Z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M254.34,219a83.76,83.76,0,0,0,22,51.32,70.76,70.76,0,0,0,22.07,16.12,70.76,70.76,0,0,1-22.07-16.12,83.76,83.76,0,0,1-22-51.32q-.27-3.88-.18-7.68Q254.07,215.07,254.34,219Z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M304.5,288.82a63.47,63.47,0,0,1-6.1-2.43A63.47,63.47,0,0,0,304.5,288.82Z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M255.93,196.54a66.46,66.46,0,0,1,16.29-31.21A66.46,66.46,0,0,0,255.93,196.54Z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M375,165.46a68.15,68.15,0,0,1,18,42.14,68.15,68.15,0,0,0-18-42.14,66.69,66.69,0,0,0-26.27-17.2A66.69,66.69,0,0,1,375,165.46Z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M393,219h0a86.19,86.19,0,0,1-8.2,31A86.19,86.19,0,0,0,393,219Z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M254.16,211.27a75.62,75.62,0,0,1,1.06-11.14A75.62,75.62,0,0,0,254.16,211.27Z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M383.19,253.16c-1.11,2.07-2.3,4.1-3.58,6.06C380.89,257.26,382.08,255.23,383.19,253.16Z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M206.88,189.05a57.86,57.86,0,0,1,15.41,38.62,57.86,57.86,0,0,0-15.41-38.62,57,57,0,0,0-30.78-17A57,57,0,0,1,206.88,189.05Z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M190,288a54.21,54.21,0,0,1-10,4.65A54.21,54.21,0,0,0,190,288Z");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M105.49,224.45a59.87,59.87,0,0,1,5.2-20.64A59.87,59.87,0,0,0,105.49,224.45Z");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M194.68,284.88C193.17,286,191.61,287,190,288,191.61,287,193.17,286,194.68,284.88Z");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M216.17,257.89a69.49,69.49,0,0,1-5.73,10.42A69.49,69.49,0,0,0,216.17,257.89Z");
		builder.CloseElement();
		builder.OpenElement(51, "path");
		builder.AddAttribute(52, "d", "M110.69,203.81a56.76,56.76,0,0,1,2.78-5.3A56.76,56.76,0,0,0,110.69,203.81Z");
		builder.CloseElement();
		builder.OpenElement(53, "path");
		builder.AddAttribute(54, "d", "M194.68,284.88a65.39,65.39,0,0,0,15.76-16.57A65.39,65.39,0,0,1,194.68,284.88Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
